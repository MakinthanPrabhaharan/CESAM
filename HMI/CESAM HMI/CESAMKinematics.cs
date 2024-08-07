using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CESAMKinematics
{
    class Kinematics
    {
        double d1, d2, d3, d4;
        public Kinematics(double d1, double d2, double d3, double d4)
        {
            this.d1 = d1;
            this.d2 = d2;
            this.d3 = d3;
            this.d4 = d4;
        }


        /// <summary>
        /// Method that performs the forward kinematics calculation for the robot, based on the 6 joint variables
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <param name="t3"></param>
        /// <param name="t4"></param>
        /// <param name="t5"></param>
        /// <param name="t6"></param>
        /// <returns>Matrix representing the pose of the end effector</returns>
        public Matrix ForwardKinematics(double t1, double t2, double t3, double t4, double t5, double t6)
        {
            Matrix H1, H2, H3, H4;

            double[,] H1_vals = { 
                {cos(t1),-sin(t1),0,0 }, 
                {sin(t1), cos(t1), 0, 0 }, 
                { 0, 0, 1,d1}, 
                { 0, 0, 0, 1 } 
            };
            H1 = new Matrix(H1_vals, 4, 4);

            double[,] H2_vals = { 
                { cos(t2), 0, sin(t2), d2},
                { 0, 1, 0,0}, 
                { -sin(t2), 0, cos(t2), 0 }, 
                { 0, 0, 0, 1 } 
            };
            H2 = new Matrix(H2_vals, 4, 4);

            double[,] H3_vals = { 
                { cos(t3), sin(t3)*sin(t3), sin(t3)*cos(t4), d3}, 
                { 0, cos(t4), -sin(t4), 0 }, 
                { sin(t3), cos(t3)*sin(t4), cos(t3)*cos(t4), 0 }, 
                { 0, 0, 0, 1 } 
            };
            H3 = new Matrix(H3_vals, 4, 4);

            double[,] H4_vals = {
                { cos(t5), sin(t5)*sin(t5), sin(t5)*cos(t6), d4},
                { 0, cos(t4), -sin(t4), 0 },
                { sin(t5), cos(t5)*sin(t6), cos(t5)*cos(t6), 0 },
                { 0, 0, 0, 1 }
            };
            H4 = new Matrix(H4_vals, 4, 4);

            
            Matrix[] homogenousTransforms = {H1, H2, H3, H4};

            Matrix resultant = Matrix.Multiply(homogenousTransforms[0], homogenousTransforms[1]);

            for(int i = 2; i < homogenousTransforms.Length; i++)
            {
                resultant = Matrix.Multiply(resultant, homogenousTransforms[i]);
            }

            return resultant;
        }

        public static double cos(double d)
        {
            double rad = d * (Math.PI / 180.0);
            return Math.Cos(rad);
        }

        public static double sin(double d)
        {
            double rad = d* (Math.PI / 180.0);
            return Math.Sin(rad);
        }
    }
    
    /// <summary>
    /// Matrix class for performing forward kinematics
    /// </summary>
    class Matrix
    {
        int nrows, ncolumns;

        double[,] values_array;

        public Matrix()
        {
            this.nrows = 1;
            this.ncolumns = 1;
            this.values_array = new double[nrows,ncolumns];
        }

        public Matrix(double[,] values_array, int nrows, int ncolumns)
        {
            this.values_array = values_array;
            this.nrows = nrows;
            this.ncolumns = ncolumns;
        }



        /// <summary>
        /// Returns a string representation of the matrix
        /// </summary>
        /// <returns></returns>
        public string ToString()
        {
            string mat_string = "{\n";

            for(int r_idx = 0; r_idx < nrows; r_idx++)
            {
                mat_string += "{";
                for(int c_idx = 0; c_idx < ncolumns; c_idx++)
                {
                    mat_string += this.values_array[r_idx, c_idx];
                    if (c_idx < ncolumns - 1) mat_string += ",";  
                }
                mat_string += "}";
                if(r_idx < nrows - 1) mat_string += ",\n";
            }

            mat_string += "\n}";
            return mat_string;
        }


        /// <summary>
        /// Multiplies two matrices together and returns the result
        /// </summary>
        /// <param name="matrix1"></param>
        /// <param name="matrix2"></param>
        /// <returns></returns>
        public static Matrix Multiply(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.ncolumns != matrix2.nrows)
            {
                throw new ArgumentException($"# of columns in matrix 1 must be equal to # of rows in matrix 2");
            }

            double[,] resultmatrix_arr = new double[matrix1.nrows, matrix2.ncolumns];

            for (int r_idx = 0; r_idx < matrix1.nrows; r_idx++)
            {
                for(int c_idx = 0; c_idx < matrix2.ncolumns; c_idx++)
                { 
                    for(int i = 0; i < matrix1.ncolumns; i++)
                    {
                       resultmatrix_arr[r_idx, c_idx] += matrix1.values_array[r_idx, i] * matrix2.values_array[i, c_idx];
                    }  
                }
            }

            return new Matrix(resultmatrix_arr, matrix1.nrows, matrix2.ncolumns);
        }

        

        
    }
}
