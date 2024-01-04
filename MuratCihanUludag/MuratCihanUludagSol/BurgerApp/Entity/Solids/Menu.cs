using BurgerApp.Entity.Abstracts;
using BurgerApp.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Entity.Solids
{
    public class Menu : IMenu
    {
        private double _priace;
        private double _sizePriace;
        private double _copyPriace;
        private double _esktraPriace;
        public Menu(string name, double priace)
        {
            Name = name;
            _priace = priace;
            _copyPriace = priace;
             
        }
        
        public string Name { get; init; }
        public int Count { get; set; } = 1; 
        public double Priace => _priace;
        public Dictionary<string, double> ekstraMalzeme { get; set; } = new Dictionary<string, double>();  
        public MenuSize Size { get; set; } = MenuSize.small;

        public void  MenuSizePluse(bool isCheck)
        {
            if (isCheck)
            {
                
                switch (Size)
                {
                    case MenuSize.small:
                        _sizePriace = _copyPriace + 0;
                        break;
                    case MenuSize.medium:
                        _sizePriace = _copyPriace + 8;
                        break;
                    case MenuSize.king:
                        _sizePriace = _copyPriace + 14;
                        break;
                }
            }
            else
            {
                switch (Size)
                {
                    case MenuSize.small:
                        _sizePriace = _copyPriace - 0;
                        break;
                    case MenuSize.medium:
                        _sizePriace = _copyPriace - 8;
                        break;
                    case MenuSize.king:
                        _sizePriace = _copyPriace - 14;
                        break;
                }
            }

        }
        public void MenuEkstraPriace(bool isChecked, double a)
        {
            if (isChecked)
            {
                _esktraPriace += a;
            
            }
            else
            {
                _esktraPriace -= a;
             
            }
        }
        public void LastPriace ()
        {
            if (_esktraPriace == 0 && _sizePriace == 0)
            {
                _priace = _priace * Count;
            }
            else
            {
                _priace =  (_esktraPriace + _sizePriace) * Count;
            }
        }
      
        public override string ToString()
        {
            return $"{Name} X {Count} = {_priace}";
        }
    }
}
