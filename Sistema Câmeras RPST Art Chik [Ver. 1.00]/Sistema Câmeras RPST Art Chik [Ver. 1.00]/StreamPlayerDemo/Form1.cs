using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    using WebEye.Controls.WinForms.StreamPlayerControl;
    using Accord.Video.FFMPEG;
    using System.Threading;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int width = 1100;
        int height = 700;



        VideoFileWriter writer;
        VideoFileWriter writer2;
        VideoFileWriter writer3;
        VideoFileWriter writer4;

        int hora = DateTime.Now.Hour;
        int dia = DateTime.Now.Day;

        int hora2 = DateTime.Now.Hour;
        int dia2 = DateTime.Now.Day;

        int hora3 = DateTime.Now.Hour;
        int dia3 = DateTime.Now.Day;

        int hora4 = DateTime.Now.Hour;
        int dia4 = DateTime.Now.Day;
        
        private void playButton_Click(object sender, EventArgs e)
        {
            var uri = new Uri(_urlTextBox.Text);            

            streamPlayerControl1.StartPlay(uri);
            _statusTextBox.Text = "Connecting...";
                        
        }
        private void stopButton_Click(object sender, EventArgs e)
        {
            
            writer.Close();
            
        }
        private void imageButton_Click(object sender, EventArgs e)
        {
            writer = new VideoFileWriter();
            writer.Open("c://Record//Frente//frente dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);
            
            _statusTextBox.Text = "Gravando";
            timer1.Enabled = true; 
            
        }
        private void UpdateButtons()
        {
            _playButton.Enabled = !streamPlayerControl1.IsPlaying;
            _stopButton.Enabled = streamPlayerControl1.IsPlaying;
            _imageButton.Enabled = streamPlayerControl1.IsPlaying;
            
        }     

        private void HandleStreamStartedEvent(object sender, EventArgs e)
        {
            UpdateButtons();

            _statusTextBox.Text = "Playing";
        }

        private void HandleStreamFailedEvent(object sender, StreamFailedEventArgs e)
        {
            UpdateButtons();

            _statusTextBox.Text = "Failed";

            MessageBox.Show(e.Error, "Stream Player Demo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void HandleStreamStoppedEvent(object sender, EventArgs e)
        {
            UpdateButtons();

            _statusTextBox.Text = "Stopped";
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {

            try
            {
                writer.WriteVideoFrame(streamPlayerControl1.GetCurrentFrame());
            }
            catch (Exception erro)
            {
                Application.Exit();
                System.Diagnostics.Process.Start(@"C:\Sistema Câmeras RPST Art Chik [Ver. 1.00]\StreamPlayerDemo\bin\x64\Debug\DVR_ArtChik.exe");
              
            }
            finally
            {
                
            }

            try
            {
                writer2.WriteVideoFrame(streamPlayerControl2.GetCurrentFrame());
            }
            catch (Exception erro)
            {
                Application.Exit();
                System.Diagnostics.Process.Start(@"C:\Sistema Câmeras RPST Art Chik [Ver. 1.00]\StreamPlayerDemo\bin\x64\Debug\DVR_ArtChik.exe");
                              
            }
            finally
            {
                
            }
            try
            {
                writer3.WriteVideoFrame(streamPlayerControl3.GetCurrentFrame());
            }
            catch (Exception erro)
            {
                Application.Exit();
                System.Diagnostics.Process.Start(@"C:\Sistema Câmeras RPST Art Chik [Ver. 1.00]\StreamPlayerDemo\bin\x64\Debug\DVR_ArtChik.exe");
                
            }
            finally
            {
               
            }
            try
            {
                writer4.WriteVideoFrame(streamPlayerControl4.GetCurrentFrame());
            }
            catch (Exception erro)
            {
                Application.Exit();
                System.Diagnostics.Process.Start(@"C:\Sistema Câmeras RPST Art Chik [Ver. 1.00]\StreamPlayerDemo\bin\x64\Debug\DVR_ArtChik.exe");
               
            }
            finally
            {
                
            }
           
           
            
            

           /* if (DateTime.Now.Minute == 10 && DateTime.Now.Second <= 2)
            {
                writer.Close();
                //timer1.Enabled = false;
                writer.Open("c://Record//Frente//frente dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() +  " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);
                //timer1.Enabled = true;
                //dia = DateTime.Now.Day;
                //hora = DateTime.Now.Hour;
            }
            if (DateTime.Now.Minute == 20 && DateTime.Now.Second <= 2)
            {
                writer.Close();
                //timer1.Enabled = false;
                writer.Open("c://Record//Frente//frente dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);
                //timer1.Enabled = true;
                //dia = DateTime.Now.Day;
                //hora = DateTime.Now.Hour;
            }
            if (DateTime.Now.Minute == 30 && DateTime.Now.Second <= 2)
            {
                writer.Close();
                //timer1.Enabled = false;
                writer.Open("c://Record//Frente//frente dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);
                //timer1.Enabled = true;
                //dia = DateTime.Now.Day;
                //hora = DateTime.Now.Hour;
            }
            if (DateTime.Now.Minute == 40 && DateTime.Now.Second <= 2)
            {
                writer.Close();
                //timer1.Enabled = false;
                writer.Open("c://Record//Frente//frente dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);
                //timer1.Enabled = true;
                //dia = DateTime.Now.Day;
                //hora = DateTime.Now.Hour;
            }
            if (DateTime.Now.Minute == 50 && DateTime.Now.Second <= 2)
            {
                writer.Close();
                //timer1.Enabled = false;
                writer.Open("c://Record//Frente//frente dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);
                //timer1.Enabled = true;
                //dia = DateTime.Now.Day;
                //hora = DateTime.Now.Hour;
            }
            if (DateTime.Now.Minute == 1 && DateTime.Now.Second <= 2)
            {
                writer.Close();
                //timer1.Enabled = false;
                writer.Open("c://Record//Frente//frente dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);
                //timer1.Enabled = true;
                //dia = DateTime.Now.Day;
                //hora = DateTime.Now.Hour;
            }*/

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _statusTextBox.Text = "";
            writer.Close();
            timer1.Enabled = false;
        }

       
        
        private void Form1_Load(object sender, EventArgs e)
        {
            var uri = new Uri(_urlTextBox.Text);

            streamPlayerControl1.StartPlay(uri);
            _statusTextBox.Text = "Connecting...";

            var uri2 = new Uri(_urlTextBox2.Text);
            streamPlayerControl2.StartPlay(uri2);
            _statusTextBox2.Text = "Connecting...";

            var uri3 = new Uri(_urlTextBox3.Text);
            streamPlayerControl3.StartPlay(uri3);
            _statusTextBox3.Text = "Connecting...";

            var uri4 = new Uri(_urlTextBox4.Text);
            streamPlayerControl4.StartPlay(uri4);
            _statusTextBox4.Text = "Connecting...";

            timer6.Enabled = true;
            
        }
       

        private void _playButton2_Click(object sender, EventArgs e)
        {
            var uri2 = new Uri(_urlTextBox2.Text);
            streamPlayerControl2.StartPlay(uri2);
            _statusTextBox2.Text = "Connecting...";
        }

        private void _stopButton2_Click(object sender, EventArgs e)
        {
            streamPlayerControl2.Stop();
            writer2.Close();
            timer2.Enabled = false;
        }

        private void _imageButton2_Click(object sender, EventArgs e)
        {
            writer2 = new VideoFileWriter();
            writer2.Open("c://Record//Escritório//escritório dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);
      

            _statusTextBox2.Text = "Gravando";
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (dia2 != DateTime.Now.Day && DateTime.Now.Minute == 2 && DateTime.Now.Second <= 2)
            {
                writer2.Close();
                //timer2.Enabled = false;
                writer2.Open("c://Record//Escritório//escritório dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);

                dia2 = DateTime.Now.Day;
                //hora2 = DateTime.Now.Hour;
            }

            writer2.WriteVideoFrame(streamPlayerControl2.GetCurrentFrame());
            if (DateTime.Now.Minute == 14 && DateTime.Now.Second <= 2)
            {
                writer2.Close();
                //timer2.Enabled = false;
                writer2.Open("c://Record//Escritório//escritório dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);
                //timer2.Enabled = true;
                //dia2 = DateTime.Now.Day;
                //hora2 = DateTime.Now.Hour;
            }
            if (DateTime.Now.Minute == 24 && DateTime.Now.Second <= 2)
            {
                writer2.Close();
                //timer2.Enabled = false;
                writer2.Open("c://Record//Escritório//escritório dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);
                //timer2.Enabled = true;
                //dia2 = DateTime.Now.Day;
                //hora2 = DateTime.Now.Hour;
            }
            if (DateTime.Now.Minute == 34 && DateTime.Now.Second <= 2)
            {
                writer2.Close();
                //timer2.Enabled = false;
                writer2.Open("c://Record//Escritório//escritório dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);
                //timer2.Enabled = true;
                //dia2 = DateTime.Now.Day;
                //hora2 = DateTime.Now.Hour;
            }
            if (DateTime.Now.Minute == 44 && DateTime.Now.Second <= 2)
            {
                writer2.Close();
                //timer2.Enabled = false;
                writer2.Open("c://Record//Escritório//escritório dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);
                //timer2.Enabled = true;
                //dia2 = DateTime.Now.Day;
                //hora2 = DateTime.Now.Hour;
            }
            if (DateTime.Now.Minute == 54 && DateTime.Now.Second <= 2)
            {
                writer2.Close();
                //timer2.Enabled = false;
                writer2.Open("c://Record//Escritório//escritório dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);
                //timer2.Enabled = true;
                //dia2 = DateTime.Now.Day;
                //hora2 = DateTime.Now.Hour;
            }
            if (DateTime.Now.Minute == 4 && DateTime.Now.Second <= 2)
            {
                writer2.Close();
                //timer2.Enabled = false;
                writer2.Open("c://Record//Escritório//escritório dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);
                //timer2.Enabled = true;
                //dia2 = DateTime.Now.Day;
                //hora2 = DateTime.Now.Hour;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            writer2.Close();
            _statusTextBox2.Text = "";
            timer2.Enabled = false;
        }

        private void _playButton3_Click(object sender, EventArgs e)
        {
            var uri3 = new Uri(_urlTextBox3.Text);
            streamPlayerControl3.StartPlay(uri3);
            _statusTextBox3.Text = "Connecting...";
        }

        private void _playButton4_Click(object sender, EventArgs e)
        {
            var uri4 = new Uri(_urlTextBox4.Text);
            streamPlayerControl4.StartPlay(uri4);
            _statusTextBox4.Text = "Connecting...";
        }

        private void _stopButton3_Click(object sender, EventArgs e)
        {
            streamPlayerControl3.Stop();
            writer3.Close();
            timer3.Enabled = false;
        }

        private void _stopButton4_Click(object sender, EventArgs e)
        {
            streamPlayerControl4.Stop();
            writer4.Close();
            timer4.Enabled = false;
        }

        private void _imageButton3_Click(object sender, EventArgs e)
        {
            writer3 = new VideoFileWriter();
            writer3.Open("c://Record//Escritório2//escritório2 dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);
   
            _statusTextBox3.Text = "Gravando";
            timer3.Enabled = true;
        }

        private void _imageButton4_Click(object sender, EventArgs e)
        {

            writer4 = new VideoFileWriter();
            writer4.Open("c://Record//Financeiro//financeiro dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);
      
            _statusTextBox4.Text = "Gravando";
            timer4.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            writer3.Close();
            _statusTextBox3.Text = "";
            timer3.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            writer4.Close();
            _statusTextBox4.Text = "";
            timer4.Enabled = false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (dia3 != DateTime.Now.Day && DateTime.Now.Minute == 3 && DateTime.Now.Second <= 2)
            {
                writer3.Close();
                // timer3.Enabled = false;
                writer3.Open("c://Record//Escritório2//escritório2 dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);
                // timer3.Enabled = true;
                dia3 = DateTime.Now.Day;
                //hora3 = DateTime.Now.Hour;
            }
            
            writer3.WriteVideoFrame(streamPlayerControl3.GetCurrentFrame());

            if (DateTime.Now.Minute == 13 && DateTime.Now.Second <= 2)
            {
                writer3.Close();
                //timer3.Enabled = false;
                writer3.Open("c://Record//Escritório2//escritório2 dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);
                //timer3.Enabled = true;
                //dia3 = DateTime.Now.Day;
                //hora3 = DateTime.Now.Hour;
            }
            if (DateTime.Now.Minute == 23 && DateTime.Now.Second <= 2)
            {
                writer3.Close();
                //timer3.Enabled = false;
                writer3.Open("c://Record//Escritório2//escritório2 dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);
                //timer3.Enabled = true;
                //dia3 = DateTime.Now.Day;
                //hora3 = DateTime.Now.Hour;
            }
            if (DateTime.Now.Minute == 33 && DateTime.Now.Second <= 2)
            {
                writer3.Close();
                //timer3.Enabled = false;
                writer3.Open("c://Record//Escritório2//escritório2 dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);
                //timer3.Enabled = true;
                //dia3 = DateTime.Now.Day;
                //hora3 = DateTime.Now.Hour;
            }
            if (DateTime.Now.Minute == 43 && DateTime.Now.Second <= 2)
            {
                writer3.Close();
                //timer3.Enabled = false;
                writer3.Open("c://Record//Escritório2//escritório2 dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);
                //timer3.Enabled = true;
                //dia3 = DateTime.Now.Day;
                //hora3 = DateTime.Now.Hour;
            }
            if (DateTime.Now.Minute == 53 && DateTime.Now.Second <= 2)
            {
                writer3.Close();
                //timer3.Enabled = false;
                writer3.Open("c://Record//Escritório2//escritório2 dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);
                //timer3.Enabled = true;
                //dia3 = DateTime.Now.Day;
                //hora3 = DateTime.Now.Hour;
            }
            if (DateTime.Now.Minute == 3 && DateTime.Now.Second <= 2)
            {
                writer3.Close();
                //timer3.Enabled = false;
                writer3.Open("c://Record//Escritório2//escritório2 dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);
                //timer3.Enabled = true;
                //dia3 = DateTime.Now.Day;
                //hora3 = DateTime.Now.Hour;
            }
            
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (dia4 != DateTime.Now.Day && DateTime.Now.Minute == 4 && DateTime.Now.Second <= 2)
            {
                writer4.Close();
                //timer4.Enabled = false;
                writer4.Open("c://Record//Financeiro//financeiro dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);
                //timer4.Enabled = true;
                dia4 = DateTime.Now.Day;
                //hora4 = DateTime.Now.Hour;
            }
            writer4.WriteVideoFrame(streamPlayerControl4.GetCurrentFrame());
            if (DateTime.Now.Minute == 12 && DateTime.Now.Second <= 2)
            {
                writer4.Close();
                //timer4.Enabled = false;
                writer4.Open("c://Record//Financeiro//financeiro dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);
                //timer4.Enabled = true;
                //dia4 = DateTime.Now.Day;
                //hora4 = DateTime.Now.Hour;
            }
            if (DateTime.Now.Minute == 22 && DateTime.Now.Second <= 2)
            {
                writer4.Close();
                //timer4.Enabled = false;
                writer4.Open("c://Record//Financeiro//financeiro dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);
                //timer4.Enabled = true;
                //dia4 = DateTime.Now.Day;
                //hora4 = DateTime.Now.Hour;
            }
            if (DateTime.Now.Minute == 32 && DateTime.Now.Second <= 2)
            {
                writer4.Close();
                //timer4.Enabled = false;
                writer4.Open("c://Record//Financeiro//financeiro dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);
                //timer4.Enabled = true;
                //dia4 = DateTime.Now.Day;
                //hora4 = DateTime.Now.Hour;
            }
            if (DateTime.Now.Minute == 42 && DateTime.Now.Second <= 2)
            {
                writer4.Close();
                //timer4.Enabled = false;
                writer4.Open("c://Record//Financeiro//financeiro dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);
                //timer4.Enabled = true;
                //dia4 = DateTime.Now.Day;
                //hora4 = DateTime.Now.Hour;
            }
            if (DateTime.Now.Minute == 52 && DateTime.Now.Second <= 2)
            {
                writer4.Close();
                //timer4.Enabled = false;
                writer4.Open("c://Record//Financeiro//financeiro dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);
                //timer4.Enabled = true;
                //dia4 = DateTime.Now.Day;
                //hora4 = DateTime.Now.Hour;
            }
            if (DateTime.Now.Minute == 2 && DateTime.Now.Second <= 2)
            {
                writer4.Close();
                //timer4.Enabled = false;
                writer4.Open("c://Record//Financeiro//financeiro dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);
                //timer4.Enabled = true;
                //dia4 = DateTime.Now.Day;
                //hora4 = DateTime.Now.Hour;
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var uri = new Uri(_urlTextBox.Text);

            streamPlayerControl1.StartPlay(uri);
            _statusTextBox.Text = "Connecting...";

            var uri2 = new Uri(_urlTextBox2.Text);
            streamPlayerControl2.StartPlay(uri2);
            _statusTextBox2.Text = "Connecting...";

            var uri3 = new Uri(_urlTextBox3.Text);
            streamPlayerControl3.StartPlay(uri3);
            _statusTextBox3.Text = "Connecting...";

            var uri4 = new Uri(_urlTextBox4.Text);
            streamPlayerControl4.StartPlay(uri4);
            _statusTextBox4.Text = "Connecting...";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            writer = new VideoFileWriter();
            writer.Open("c://Record//Frente//frente dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);
            _statusTextBox.Text = "Gravando";
             

            writer2 = new VideoFileWriter();
            writer2.Open("c://Record//Escritório//escritório dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);
            _statusTextBox2.Text = "Gravando";

            writer3 = new VideoFileWriter();
            writer3.Open("c://Record//Escritório2//escritório2 dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);
            _statusTextBox3.Text = "Gravando";


            writer4 = new VideoFileWriter();
            writer4.Open("c://Record//Financeiro//financeiro dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);
            _statusTextBox4.Text = "Gravando";


            timer1.Enabled = true;
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (dia != DateTime.Now.Day && DateTime.Now.Minute == 1 && DateTime.Now.Second <= 2)
            {
                timer1.Enabled = false;

                writer.Close();
                //writer.Open("c://Record//Frente//frente dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);

                writer2.Close();
                //writer2.Open("c://Record//Escritório//escritório dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);
                

                writer3.Close();
                //writer3.Open("c://Record//Escritório2//escritório2 dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);
                

                writer4.Close();
               // writer4.Open("c://Record//Financeiro//financeiro dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);

                Application.Exit();
                System.Diagnostics.Process.Start(@"C:\Sistema Câmeras RPST Art Chik [Ver. 1.00]\StreamPlayerDemo\bin\x64\Debug\DVR_ArtChik.exe");
                //dia = DateTime.Now.Day;

                //timer1.Enabled = true;
                
            }
            
            if (DateTime.Now.Minute == 1 && DateTime.Now.Second <= 2)
            {
                timer1.Enabled = false;

                writer.Close();
                //writer.Open("c://Record//Frente//frente dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);

                writer2.Close();
                //writer2.Open("c://Record//Escritório//escritório dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);


                writer3.Close();
                //writer3.Open("c://Record//Escritório2//escritório2 dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);


                writer4.Close();
                //writer4.Open("c://Record//Financeiro//financeiro dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);

                Application.Exit();
                System.Diagnostics.Process.Start(@"C:\Sistema Câmeras RPST Art Chik [Ver. 1.00]\StreamPlayerDemo\bin\x64\Debug\DVR_ArtChik.exe");
                //dia = DateTime.Now.Day;

                //timer1.Enabled = true;
            }
            if (DateTime.Now.Minute == 30 && DateTime.Now.Second <= 2)
            {
                timer1.Enabled = false;

                writer.Close();
                //writer.Open("c://Record//Frente//frente dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);

                writer2.Close();
                //writer2.Open("c://Record//Escritório//escritório dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);


                writer3.Close();
                //writer3.Open("c://Record//Escritório2//escritório2 dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);


                writer4.Close();
                //writer4.Open("c://Record//Financeiro//financeiro dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);

                Application.Exit();
                System.Diagnostics.Process.Start(@"C:\Sistema Câmeras RPST Art Chik [Ver. 1.00]\StreamPlayerDemo\bin\x64\Debug\DVR_ArtChik.exe");
                //dia = DateTime.Now.Day;

                //timer1.Enabled = true;
            }


        }
       
        private void timer6_Tick(object sender, EventArgs e)
        {
            writer = new VideoFileWriter();
            writer.Open("c://Record//Frente//frente dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);
            _statusTextBox.Text = "Gravando";


            writer2 = new VideoFileWriter();
            writer2.Open("c://Record//Escritório//escritório dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);
            _statusTextBox2.Text = "Gravando";

            writer3 = new VideoFileWriter();
            writer3.Open("c://Record//Escritório2//escritório2 dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);
            _statusTextBox3.Text = "Gravando";


            writer4 = new VideoFileWriter();
            writer4.Open("c://Record//Financeiro//financeiro dia " + DateTime.Now.Day.ToString() + " hora " + DateTime.Now.Hour.ToString() + " minutos " + DateTime.Now.Minute.ToString() + ".avi", width, height, 5, VideoCodec.H264, 80000);
            _statusTextBox4.Text = "Gravando";


            timer1.Enabled = true;

            timer6.Enabled = false;
        }
        
       
    }
}
