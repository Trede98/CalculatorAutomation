
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace CalculatorAutomation
{
    class Calc
    {
        private Application calc;
        private Window window;
        private Button zero, one, two, three, four, five, six, seven, eight, nine;
        private Button equal, plus, minus, multiply, divide, backSpace, clear, clearAll;
        private Label result;

        private static Calc instance;
        public Calc()
        {
        }

        public static Calc getInstance()
        {
            if (instance == null)
                instance = new Calc();
            return instance;
        }

        public void Initialize()
        {
            //Avvia la calcolatrice
            calc = Application.Launch("calc.exe");
            //Prende l'oggetto finestra della calcolatrice
            window = calc.GetWindow("Calcolatrice", InitializeOption.NoCache);


            //NUMPAD
            zero = window.Get<Button>(SearchCriteria.ByAutomationId("130"));
            one = window.Get<Button>(SearchCriteria.ByAutomationId("131"));
            two = window.Get<Button>(SearchCriteria.ByAutomationId("132"));
            three = window.Get<Button>(SearchCriteria.ByAutomationId("133"));
            four = window.Get<Button>(SearchCriteria.ByAutomationId("134"));
            five = window.Get<Button>(SearchCriteria.ByAutomationId("135"));
            six = window.Get<Button>(SearchCriteria.ByAutomationId("136"));
            seven = window.Get<Button>(SearchCriteria.ByAutomationId("137"));
            eight = window.Get<Button>(SearchCriteria.ByAutomationId("138"));
            nine = window.Get<Button>(SearchCriteria.ByAutomationId("139"));

            //OPERATOR
            equal = window.Get<Button>(SearchCriteria.ByAutomationId("121"));
            plus = window.Get<Button>(SearchCriteria.ByAutomationId("93"));
            minus = window.Get<Button>(SearchCriteria.ByAutomationId("94"));
            multiply = window.Get<Button>(SearchCriteria.ByAutomationId("92"));
            divide = window.Get<Button>(SearchCriteria.ByAutomationId("91"));
            backSpace = window.Get<Button>(SearchCriteria.ByAutomationId("83"));
            clear = window.Get<Button>(SearchCriteria.ByAutomationId("82"));
            clearAll = window.Get<Button>(SearchCriteria.ByAutomationId("81"));

            //RESULT
            result = window.Get<Label>(SearchCriteria.ByAutomationId("158"));
        }

        public void openApp()
        {
            Initialize();
        }

        public void closeApp()
        {
            calc.Close();
        }


        //NUMPAD CLICK
        public void clickZero()
        {
            zero.Click();
        }

        public void clickOne()
        {
            one.Click();
        }

        public void clickTwo()
        {
            two.Click();
        }

        public void clickThree()
        {
            three.Click();
        }

        public void clickFour()
        {
            four.Click();
        }

        public void clickFive()
        {
            five.Click();
        }

        public void clickSix()
        {
            six.Click();
        }

        public void clickSeven()
        {
            seven.Click();
        }

        public void clickEight()
        {
            eight.Click();
        }

        public void clickNine()
        {
            nine.Click();
        }

        //OPERATOR CLICK

        public void clickEqual()
        {
            equal.Click();
        }

        public void clickPlus()
        {
            plus.Click();
        }

        public void clickMinus()
        {
            minus.Click();
        }

        public void clickMultiply()
        {
            multiply.Click();
        }

        public void clickDivide()
        {
            divide.Click();
        }

        public void clickBackSpace()
        {
            backSpace.Click();
        }

        public void clickClear()
        {
            clear.Click();
        }

        public void clickClearAll()
        {
            clearAll.Click();
        }


        //RESULT
        public int getResult()
        {
            int res;
            System.Int32.TryParse(result.Text, out res);
            return res;
        }

      

    }
}
