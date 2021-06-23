using System.Collections.Generic;

namespace OOTPiSP_labs
{
    class Storage
    {
        private List<Figure> figureList;
        private Stack<Figure> figureStack; 

        public Storage()
        {
            figureList = new List<Figure>();
            figureStack = new Stack<Figure>();
        }

        public void AddToStorage(Figure figure)
        {
            figureList.Add(figure);
        }

        public List<Figure> GetList()
        {
            return figureList;
        }

        public void DeleteFigure()
        {
            figureStack.Push(figureList[figureList.Count - 1]);
            figureList.RemoveAt(figureList.Count - 1);  
        }

        public void Redo()
        {
            if (figureStack.Count != 0)
                figureList.Add(figureStack.Pop());
        }

        public void ResetStack()
        {
            figureStack = new Stack<Figure>();
        }
    }
}
