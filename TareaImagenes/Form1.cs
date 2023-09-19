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
        

        public Form1()
        {
            InitializeComponent();
            aleatorio();
            cargarImagenes();
         
        }

      

        private void cargarImagenes()
        {
            for (int i = 0; i < 20; i++) {
                Button boton = new Button();
                boton.Width = 60;
                boton.Height = 60;
                boton.BackgroundImage = Image.FromFile(@"imagenes\" + listImagenes[i] + ".JPG");
                boton.BackgroundImageLayout = ImageLayout.Zoom;
                flp2.Controls.Add(boton);
            }
        }

       

            
        
        

    

       

       
       

       

        // Debería funcionar
        private void aleatorio() {
            Random aleatorio = new Random();
            for (int i = 0; i < listImagenes.Length; i++) {
                int numAleatorio = aleatorio.Next(0, 19);
                while (aleatorios.Contains(numAleatorio)) {
                    numAleatorio = aleatorio.Next(0, 19);
                }
                listImagenes[i] = numAleatorio;
                aleatorios.Add(numAleatorio);
               
            }
           
        }


        
                
                    

           

        }





       

      
    }


    

    
  



