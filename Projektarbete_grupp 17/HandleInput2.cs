using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete_grupp_17
{
    class HandleInput2 : IHandler<Form>
    {
        
        public string[] arg2Array;
        
        private int x;
        private int y;

        private int omkrets;
        private string formtyp;
        List<Form> formLista = new List<Form>();



        
        public HandleInput2 (string arg2)

        {
            Form nyForm;
           

            arg2Array = arg2.Split(";");
            Koordinat koordinat;

            for (int i = 0; i < arg2Array.Length; i++)
            {
                formtyp = arg2Array[i].Trim();
                string [] formVärden = formtyp.Split(",");

                for (int j = 0; j < formVärden.Length; j++)
                {
                    formVärden[j] = formVärden[j].Trim();
                }
                if (arg2Array.Length - 1 == i && arg2Array[i] == "")
                {

                }
                else if (formVärden.Length!=4)
                {
                    Console.WriteLine("Your input for the shapes is incorrect.\n" +
                  " It should follow this format: SHAPE, X, Y, PERIMETER" +
                  " Each point should also be separated with a ‘;’");
                    Environment.Exit(0);
                }
                else
                {
                    formtyp = formVärden[0];
                    x = Convert.ToInt32(formVärden[1]);
                    y = Convert.ToInt32(formVärden[2]);
                    omkrets = Convert.ToInt32(formVärden[3]);
                    koordinat = new Koordinat(x, y);


                    switch (formtyp)
                    {
                        case "CIRCLE":

                            nyForm = new Cirkel(formtyp, koordinat, omkrets) ;
                            formLista.Add(nyForm);

                            break;

                        case "SQUARE":

                            
                            nyForm = new Fyrkant(formtyp, koordinat, omkrets);
                            formLista.Add(nyForm);
                           
                            break;
                        case "TRIANGLE":
                            int antalKanter = 3;
                            nyForm = new Polygon(formtyp, koordinat, omkrets, antalKanter);
                            formLista.Add(nyForm);

                            break;
                        case "PENTAGON":

                            antalKanter = 5;

                            nyForm = new Polygon(formtyp, koordinat, omkrets, antalKanter);
                            formLista.Add(nyForm);

                            break;

                        case "HEXAGON":
                            antalKanter = 6;

                            nyForm = new Polygon(formtyp, koordinat, omkrets, antalKanter);
                            formLista.Add(nyForm);

                            break;

                        case "HEPTAGON":

                            antalKanter = 7;

                            nyForm = new Polygon(formtyp, koordinat, omkrets, antalKanter);
                            formLista.Add(nyForm);

                            break;


                        case "OCTAGON":

                            antalKanter = 8;

                            nyForm = new Polygon(formtyp, koordinat, omkrets, antalKanter);
                            formLista.Add(nyForm);

                            break;
                    }
                }
            }
        }

        public List<Form> HandleInput()
        {
            return formLista;
        }
    }
}
