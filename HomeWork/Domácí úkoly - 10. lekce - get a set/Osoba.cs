using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domácí_úkoly___10._lekce___get_a_set;

internal class Osoba
{
    private string _jmeno;
    private string _prijmeni;
    private int _vek;
    private bool _jePlnoleta;
    public string Jmeno 
    {
        get { return _jmeno; }
        set { _jmeno = value; }
    }
    public string Prijmeni
    {
        get { return _prijmeni; }
        set { _prijmeni = value; }
    }
    public int Vek 
    {
        get 
        { 
            return _vek; 
        }
        set 
        {  
            if (_vek >= 0 && _vek<=100) 
            {
                _vek = value;
                if (_vek >= 18)
                {
                    _jePlnoleta = true;
                }
                else
                {
                    _jePlnoleta = false;
                }
            }
            else
            {
                Console.WriteLine("Vek je zadan spatne");
            }
        }
    }
    public bool JePlnoleta { get { return _jePlnoleta; } }
}
