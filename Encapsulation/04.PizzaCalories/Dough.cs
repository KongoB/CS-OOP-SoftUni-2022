using System;
using System.Linq;

namespace _04.PizzaCalories
{
    public class Dough
    {

        private int calloriesPerGram = 2;
        private string _flourType;
        private string _bakingTechnique;
        private double _grams;


        public Dough(string flourtype, string bakingTechnique, double grams)
        {

            this.FlourType = flourtype;
            this.BakingTechnique = bakingTechnique;
            this.Grams = grams;

        }


        public string FlourType 
        {
            get
            {
                return _flourType;
            } 
            private set
            {

                string[] types = new string[2] { "White", "Wholegrain" };

                if (!types.Contains(value))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }


                this._flourType = value;
            }
        }

        public string BakingTechnique 
        {
            get
            {
                return this._bakingTechnique;
            } 
            private set
            {

                string[] types = new string[3] { "Crispy", "Chewy", "Homemade" };

                if (!types.Contains(value))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }


                this._bakingTechnique = value;
            } 
        }

        public double Grams 
        {
            get
            {
                return this._grams;
            }
            private set
            {

                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

                this._grams = value;

            } 
        }

        public int CalloriesPerGram 
        {
            get
            {
                return this.calloriesPerGram;
            } 
        }



        public double CalculateCalories()
        {

            double totalCalories = Grams * CalloriesPerGram;


            switch (FlourType)
            {
                case "White":
                    totalCalories *= 1.5;
                    break;
                case "Wholegrain":
                    totalCalories *= 1;
                    break;
                default:
                    break;
            }

            switch (BakingTechnique)
            {
                case "Crispy":
                    totalCalories *= 0.9;
                    break;
                case "Chewy":
                    totalCalories *= 1.1;
                    break;
                case "Homemade":
                    totalCalories *= 1;
                    break;
                default:
                    break;
            }


            return totalCalories;

        }


    }
}
