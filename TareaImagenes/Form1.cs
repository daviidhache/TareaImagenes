using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaImagenes
{
    
    public partial class Form1 : Form
    {
       
         static int[] listImagenes = new int[20];
        static ArrayList aleatorios = new ArrayList();
         static int salida;
        

        public Form1()
        {
            InitializeComponent();
            aleatorio();
            cargarImagenes();
            button1.Enabled = false;
            timer1.Start();
         
        }

      

        private void cargarImagenes()
        {
            for (int i = 0; i < 20; i++) {
                Button boton = new Button();
                boton.Click += Boton_Click;
                boton.Width = 60;
                boton.Height = 60;
                boton.BackgroundImage = Image.FromFile(@"imagenes\" + listImagenes[i] + ".JPG");
                boton.Tag = listImagenes[i];
                boton.BackgroundImageLayout = ImageLayout.Zoom;
                flp2.Controls.Add(boton);

               
            }
        }

        private void Boton_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            
                
                if (salida == Convert.ToInt32(boton.Tag))
                {
                    boton.BackgroundImage = Image.FromFile(@"imagenes\" + listImagenes[Convert.ToInt16(boton.Tag)] + ".JPG");
                    MessageBox.Show("Me encontraste");
                timer1.Start();
                }
                else {
                    boton.BackgroundImage = Image.FromFile(@"imagenes\" + listImagenes[Convert.ToInt16(boton.Tag)] + ".JPG");
                    MessageBox.Show("Fallaste");
                    boton.BackgroundImage = Image.FromFile(@"back.png");

            }

                
            
          
            
        }
















        // Debería funcionar
        private void aleatorio() {
            Random aleatorio = new Random();
            for (int i = 0; i < listImagenes.Length; i++) {
                int numAleatorio = aleatorio.Next(0, 20);
                while (aleatorios.Contains(numAleatorio)) {
                    numAleatorio = aleatorio.Next(0, 20);
                }
                listImagenes[i] = numAleatorio;
                aleatorios.Add(numAleatorio);
               
            }

           
           
        }



        private void imagenadivinar()
        {

            salida = new Random().Next(0, 20);
            label1.Image = Image.FromFile(@"imagenes\" + listImagenes[salida]   + ".JPG");
            label1.Enabled = true;


           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            imagenadivinar();
            button1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Enabled = false;
            foreach (Control dato in flp2.Controls) { 
                dato.BackgroundImage = Image.FromFile(@"back.png");
                dato.BackgroundImageLayout = ImageLayout.Zoom;

            }
            timer1.Stop();
            button1.Enabled = true;

        }



       
    }





       

      
    }


    

    
  



