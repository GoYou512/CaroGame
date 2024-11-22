using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GameCaro.SocketData;

namespace GameCaro
{
    public partial class Form1 : Form
    {
        #region Properties
        ChessBoardManager ChessBoard;

        SocketManager socket;
        #endregion
        public Form1()
        {
            InitializeComponent();

            Control.CheckForIllegalCrossThreadCalls = false;

            ChessBoard = new ChessBoardManager(pnlChessBoard, txbPlayerName, pctbMark);
            ChessBoard.EndedGame += ChessBoard_EndedGame;
            ChessBoard.PlayerMarked += ChessBoard_PlayerMarked;

            prcbCoolDown.Step = Cons.COOLDOWN_STEP;
            prcbCoolDown.Maximum = Cons.COOLDOWN_TIME;
            prcbCoolDown.Value = 0;

            tmCoolDown.Interval = Cons.COOLDOWN_INTERVAL;

            socket = new SocketManager();

            NewGame();
        }

        #region Methods
        void Endgame()
        {
            tmCoolDown.Stop();
            pnlChessBoard.Enabled = false;
            //MessageBox.Show("End Game!");
        }

        void NewGame()
        {
            ChessBoard.DrawChessBoard();
            prcbCoolDown.Value = 0;
            tmCoolDown.Stop();
        }

        void Quit()
        {
            Application.Exit();
        }


       
        private void ChessBoard_PlayerMarked(object? sender, ButtonClickEvent e)
        {
            tmCoolDown.Start();
            pnlChessBoard.Enabled = false;
            prcbCoolDown.Value = 0;

            socket.Send(new SocketData((int)SocketCommand.SEND_POINT, "", e.ClickedPoint));


            Listen();
        }

         void ChessBoard_EndedGame(object? sender, EventArgs e)
        {
            Endgame();

            socket.Send(new SocketData((int)SocketCommand.END_GAME, "", new Point()));

        }

        private void tmCoolDown_Tick(object sender, EventArgs e)
        {
            prcbCoolDown.PerformStep();
            if (prcbCoolDown.Value >= prcbCoolDown.Maximum)
            {
                Endgame();
                socket.Send(new SocketData((int)SocketCommand.TIME_OUT, "", new Point()));

            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
            socket.Send(new SocketData((int)SocketCommand.NEW_GAME, "", new Point()));
            pnlChessBoard.Enabled=true;

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Quit Game?", "Th�ng b�o", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
            else
            {
                try
                {
                    socket.Send(new SocketData((int)SocketCommand.QUIT, "", new Point()));
                }
                catch { }

            }
        }

        private void btnLAN_Click(object sender, EventArgs e)
        {
            socket.IP = txbIP.Text;

            if (!socket.ConnectServer())
            {
                socket.isServer = true;
                pnlChessBoard.Enabled = true;
                socket.CreateServer();
                btnLAN.Enabled = false;

            }
            else
            {
                socket.isServer = false;
                pnlChessBoard.Enabled = false;
                Listen();
                btnLAN.Enabled = false;
            }
            
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            txbIP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);
            if (string.IsNullOrEmpty(txbIP.Text))
            {
                txbIP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
            }
        }

        void Listen()
        {
                Thread listenThread = new Thread(() =>
                {
                    try
                    {

                        SocketData data = (SocketData)socket.Receive();
    
                        ProcessData(data);
                    } 
                    catch (Exception e)
                    {
                    }
                });
                listenThread.IsBackground = true;
                listenThread.Start();
            }
            
        

        private void ProcessData(SocketData data)
        {
            switch (data.Command)
            { 
                case (int)SocketCommand.NOTIFY:
                        MessageBox.Show(data.Message);
                    break;
                case (int)SocketCommand.NEW_GAME:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        NewGame();
                        pnlChessBoard.Enabled = false ;
                    }));
                    break;
                case (int)SocketCommand.SEND_POINT:
                    this.Invoke((MethodInvoker)(() => 
                    {
                        prcbCoolDown.Value = 0;
                        pnlChessBoard.Enabled = true;
                        tmCoolDown.Start();
                        ChessBoard.OtherPlayerMark(data.Point);

                    }));
                    
                    break;
                case (int)SocketCommand.END_GAME:
                    MessageBox.Show("5 in line to Win!");
                    break;
                case (int)SocketCommand.TIME_OUT:
                    MessageBox.Show("TIME OUT!");
                    break;
                case (int)SocketCommand.QUIT:
                    tmCoolDown.Stop();
                    MessageBox.Show("Player has exited");
                    break;

                default:
                    break;
            }

        Listen();
        }

        #endregion


    }

}
