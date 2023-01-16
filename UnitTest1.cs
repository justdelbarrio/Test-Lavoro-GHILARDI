using quadro.libreria;
namespace TestNICOLAGHILARDI
{
    public class UnitTest1
    {
        public void Test()
        {
            Quadro quadro;

            Quadro quadro2;

            [Fact]
            void Test1()
            {
                Quadro quadro = new Quadro("Picasso", 75, 246, 324, 750);
                Quadro quadro2 = new Quadro("Monet", 45, 124, 300, 450);
                Assert.False(quadro.Equals(quadro2));           
            }
            
            [Fact]
            void Test2()
            {
                Quadro quadro = new Quadro("Picasso", 75, 246, 324, 750);
                Quadro quadro2 = new Quadro("Monet", 45, 124, 300, 450);
                float a = quadro.Altezza;

                quadro.ModDati(5, 3, 1, 3);

                Assert.False(quadro.Altezza == a);

            }
            [Fact]
            void Test20()
            {
                Quadro quadro = new Quadro("Picasso", 75, 246, 324, 750);
                Quadro quadro2 = new Quadro("Monet", 45, 124, 300, 450);
                float a = quadro.Lunghezza;

                quadro.ModDati(5, 3, 1, 3);

                Assert.False(quadro.Lunghezza == a);
            }
            [Fact]
            void Test21()
            {
                Quadro quadro = new Quadro("Picasso", 75, 246, 324, 750);
                Quadro quadro2 = new Quadro("Monet", 45, 124, 300, 450);
                float a = quadro.PrezzoOff;

                quadro.ModDati(5, 3, 1, 3);

                Assert.False(quadro.PrezzoOff == a);
            }
            [Fact]
            void Test22()
            {
                Quadro quadro = new Quadro("Picasso", 75, 246, 324, 750);
                Quadro quadro2 = new Quadro("Monet", 45, 124, 300, 450);
                float a = quadro.PrezzoTras;

                quadro.ModDati(5, 3, 1, 3);

                Assert.False(quadro.PrezzoTras == a);
            }
                    [Fact]
                    void Test3()
                    {
                        Quadro quadro = new Quadro("Picasso", 75, 246, 324, 750);
                        Quadro quadro2 = new Quadro("Monet", 45, 124, 300, 450);

                        Quadro a=quadro;
                        Quadro b=quadro2;
                        quadro.Confronta(a, b);

                        Assert.True(a.PrezzoOff > b.PrezzoOff);
                    }
                    [Fact]
                    void Test30()
                    {
                        Quadro quadro = new Quadro("Picasso", 75, 246, 324, 750);
                        Quadro quadro2 = new Quadro("Picasso", 75, 246, 324, 750);

                        Quadro a = quadro;
                        Quadro b = quadro2;
                        quadro.Confronta(a, b);

                        Assert.True(a.PrezzoOff == b.PrezzoOff);
                    }
            
                    [Fact]
                    void Test4()
                    {
                        Quadro quadro = new Quadro("Picasso", 75, 246, 324, 750);
                        Quadro quadro2 = new Quadro("Monet", 45, 124, 300, 450);

                        float a = quadro.PrezzoOff+100;

                        quadro.Offerta(a);

                        Assert.False(a>quadro.PrezzoOff);
                        //da eccezione quindi funziona
                    }
                    [Fact]
                    void Test40()
                    {
                        Quadro quadro = new Quadro("Picasso", 75, 246, 324, 750);
                        Quadro quadro2 = new Quadro("Monet", 45, 124, 300, 450);

                        float a = quadro.PrezzoOff-10;

                        quadro.Offerta(a);

                        Assert.True(a > quadro.PrezzoOff);
                        //da eccezione quindi funziona
                    }

                    [Fact]

                    void Test5()
                    {
                        Quadro quadro = new Quadro("Picasso", 75, 246, 324, 750);
                        Quadro quadro2 = new Quadro("Monet", 45, 124, 300, 450);

                        quadro.Trasporto();
                        Assert.True(quadro.RichiediTras==true);   
                    }
                    [Fact]
                    void Test6()
                    {
                        Quadro quadro = new Quadro("Picasso", 75, 246, 324, 750);

                        string a = Convert.ToString(quadro.PrezzoOff);

                        Assert.True(quadro.Ultimaoff() == a);
                    }
                    [Fact]
                    void Test7()
                    {
                        Quadro quadro = new Quadro("Picasso", 75, 246, 324, 750);
                        float a = quadro.PrezzoOff + quadro.PrezzoTras;
                        string b = Convert.ToString(a);

                        Assert.True(quadro.Prezzofin()==b);
                    }
            
        }
    }
}