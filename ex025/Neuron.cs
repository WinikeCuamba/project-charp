﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Network
{
    class Neuron
    {
        #region 1.VARIABLES AND PROPERTIES
        // ------------------- 1.VARIABLES AND PROPERTIES ------------------- 
        // Constants
        private static double bias = 1.0;

        // Forward instances with its properties
        public double LearningRate { get; set; }
        public double[] Input { get; set; }  //private double[] inputs;

        // The bias weight is found in the first position (Weights[0])
        public double[] Weights { get; set; }   //private double[] weights;

        // Output from the Neuron
        public double Output { get; set; }  //private double output;

        // Backward instances with its properties
        public double ExpectedOutput { get; set; }  //private double expectedOutput;
        public double Error { get; set; }   //private double error;
        public double BackPropagatedError { get; set; } //private double backPropagatedError;
        #endregion

        #region 2.CONSTRUCTORS
        //  ------------------- 2.CONSTRUCTORS ------------------- 
        public Neuron(double learningRate){
            LearningRate = learningRate;
        }

        public Neuron(double[] input, double learningRate)
        {
            Input = input;
            //SortWeights();
            LearningRate = learningRate;
        }
        #endregion

        //  ------------------- 3.PROPERTIES ------------------- 
        public static double Bias
        {
            get { return bias; }
            set { bias = value; }
        }

        //  ------------------- 4.FUNCTIONAL METHODS ------------------- 
        /**
         * Sorteia o peso para cada entrada incluindo o bias
         */
        private void SortWeights()
        {
            // Instantiating weights vector
            // First position to store bias weight
            Weights = new double[Input.Length + 1];

            // Instantiating the class to random numbers generation
            Random random = new Random( DateTime.Now.Millisecond );

            // Filling the weights vector
            for (int i = 0; i < Weights.Length; i++)
                Weights[i] = random.Next(-1000, 1000) / 1000.0;
        }

        #region Error's calculus
        public void CalculateError()
        {
            // Error calculation
            Error = ExpectedOutput - Output;
        }

        public void CalculateBackPropagatedError()
        {
            // Back propagated error calculation
            BackPropagatedError = (1.0 - Output * Output) * Error;
        }
        #endregion

        public void WeightsAdjustment()
        {
            Weights[0] += LearningRate * Bias * BackPropagatedError;
            for (int i = 1; i < Weights.Length; i++)
                Weights[i] += LearningRate * Input[i - 1] * BackPropagatedError;
        }

        /**
         * Realiza o processo de propagação
         */
        public void Forward()
        {
            // Performing the sum of the inputs with the weights
            double sum = Bias * Weights[0];
            for ( int i = 0; i < Input.Length; i++ )
                sum += Input[ i ] * Weights[ i + 1 ];

            // Validation function
            Output = Math.Tanh( sum );
        }

        /**
         * Realiza o processo de retro-propagação
         */
        public void Backward( double[] inputs, double expectedOutput )
        {
            Input = inputs;
            ExpectedOutput = expectedOutput;

            // Call to Forward method to realize the respective calculus
            Forward();

            // Calculate Error and Back Propagated Error
            CalculateError();
            CalculateBackPropagatedError();

            // Weights adjustment
            WeightsAdjustment();
        }
    }
}
