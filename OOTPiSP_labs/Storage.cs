using System.Collections.Generic;

namespace OOTPiSP_labs
{
    class Storage
    {
        private List<Figure> figureList;

        public Storage()
        {
            figureList = new List<Figure>();
        }

        public void AddToStorage(Figure figure)
        {
            figureList.Add(figure);
        }

        public List<Figure> GetList()
        {
            return figureList;
        }
    }
}
