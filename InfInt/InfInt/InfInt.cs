using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Ana Maghradze 
/// 823356346
/// </summary>
namespace Assignment_2
{
    class InfInt : IComparable<InfInt>
    {
        private List<int> digits = new List<int>();
        private bool sign = false;

        // default constructor
        public InfInt() { }
        // explicit value constructor
        public InfInt(string largeNum)
        {
            if (largeNum.StartsWith("-"))
            {
                largeNum = largeNum.Replace('-', ' ').Trim(); // get rid of '-'
                sign = true;
            }
            else
            {
                sign = false;
            }
            digits = largeNum.Select(digit => digit - '0').ToList();            
        }

        // compare two operands
        public int CompareTo(InfInt other)
        {
            var result = 0;
            if (this.digits.Count != other.digits.Count) //if number of digits are different
            {
                result = this.digits.Count.CompareTo(other.digits.Count); //returns 1 if a > b, -1 if a < b
            }
            // if number of digits in each operand is the same
            else
            {
                var i = 0;
                while (i < this.digits.Count) // digit by digit comparison
                {
                   if (this.digits[i] == other.digits[i]) {  i++; } // if equal, increment i
                   else { return this.digits[i].CompareTo(other.digits[i]); }
                }
            }
            return result;
        }

        // Adds digits of Infints
        public InfInt AddDigits(InfInt b)
        {
            var op1 = this; // first operand 
            var op2 = b;    // second operand

            if ((this.CompareTo(b) == -1 && (this.digits.Count == b.digits.Count))
                || (this.CompareTo(b) == -1 && (this.digits.Count != b.digits.Count)))
            {
                op1 = b;    // larger number becomes first operand
                op2 = this;
            }
            else
            {
                op1 = this; // larger number is still first operand
                op2 = b;
            }
            // reverse digits
            op1.digits.Reverse();  
            op2.digits.Reverse();
            var sum = 0;
            var carry = 0;
            var result = new InfInt();

            for (int i = 0; i < op1.digits.Count; i++)
            {
                if (i < op2.digits.Count)
                {
                    sum = op1.digits[i] + op2.digits[i] + carry;
                    if (i == (op1.digits.Count - 1) && sum >= 10) // sum of last digits 
                    {
                        result.digits.Add(sum % 10);
                        carry = 1;
                    }
                    else
                    {
                        result.digits.Add(sum % 10); // add remainder to result 
                        if (sum >= 10)  {  carry = 1;  }
                        else { carry = 0;  }
                    }
                }
                // if digits in op2 < digits in op1
                else
                {
                    sum = op1.digits[i] + carry;
                    result.digits.Add(sum % 10);
                    if (sum >= 10) { carry = 1; }
                    else  { carry = 0; }
                }
            }
            // carry if sum of last digits >= 10
            if (carry == 1)
            {
                result.digits.Add(1);
            }
            // Re-Reverse InfInts
            op1.digits.Reverse(); 
            op2.digits.Reverse();
            result.digits.Reverse(); // Reverse Result
            return result; 
        }
        // Adds Infints and determines the sign of the sum  
        public string Plus(InfInt b)
        {
            var result = "";
            var sign = "";
            if (this.sign == true && b.sign == true) // --
            {
                result = (this.AddDigits(b)).ToString();
                sign = "-";
            }
            else if (this.sign == false && b.sign == false) // ++
            {
                result = (this.AddDigits(b)).ToString();
            }
            else if (this.sign == false && b.sign == true) // +-
            {
                result = b.SubtractDigits(this);
            }
            else
            {
                result = this.SubtractDigits(b);  // -+  a<b
                if(this.CompareTo(b) == 1)
                {
                    sign = "-";
                }
            }

            return sign+result.ToString().TrimStart('0');
        }

        // subtracts digits of infint 
        public string SubtractDigits(InfInt b)
        {
            var op1 = this; // first operand 
            var op2 = b;    // second operand

            if (this.CompareTo(b) == -1)
            {
                op1 = b;    // larger number becomes first operand
                op2 = this;
            }
            else
            {
                op1 = this; // larger number is first operand
                op2 = b;
            }
            // reverse digits
            op1.digits.Reverse();  
            op2.digits.Reverse();
            var diff = 0;
            var carry = 0;
            var result = new InfInt();

            for (int i = 0; i < op1.digits.Count; i++)
            {
                if (i < op2.digits.Count)
                {
                    if ((op1.digits[i] - op2.digits[i] + carry) < 0) // a-b < 0
                    {
                        diff = 10 + op1.digits[i] - op2.digits[i] + carry;
                        result.digits.Add(diff);
                        carry = -1;
                    }
                    else
                    {
                        diff = op1.digits[i] - op2.digits[i] + carry;
                        result.digits.Add(diff);
                        carry = 0;
                    }
                }
                // if digits in op1 > digits in op2 
                else
                {
                    diff = op1.digits[i] + carry;
                    if(diff < 0)
                    {
                        result.digits.Add(10+carry);
                        carry = -1;
                    }
                    else
                    {
                        result.digits.Add(diff);
                        carry = 0;
                    }
                }
            }
            // Re-Reverse InfInts
            op1.digits.Reverse(); 
            op2.digits.Reverse();
            result.digits.Reverse(); // Reverse Result
            return result.ToString().TrimStart('0');
        }
        // subtracts InfInts and determines sign of the result
        public string Minus(InfInt b)
        {
            var result = "";
            var sign = "";
            if ((this.sign == true && b.sign == true)) // -- 
            {
                result = this.SubtractDigits(b);  // -a-(-b) = -(a-b)  a>b
                if(this.CompareTo(b) == 1)
                {
                    sign = "-";
                }
            }
            else if (this.sign == false && b.sign == false) // ++
            {
                result = this.SubtractDigits(b); // a-b
                if (this.CompareTo(b) == -1)    // if a<b 
                {
                    sign = "-";
                }
            }
            else if (this.sign == false && b.sign == true) // +-
            {
                result = (this.AddDigits(b)).ToString();  //  a-(-b) = a+b
            }
            else
            {
                result = this.SubtractDigits(b);
            }

            return sign + result.ToString();
        }
        // Myltiplies digits of two Infints       
        public string MultiplyDigits(InfInt b)
        {
            var op1 = this; // first operand 
            var op2 = b;    // second operand
            if (this.digits.Count >= b.digits.Count)
            {
                op1 = this; // larger number is first operand
                op2 = b;
            }
            else
            {
                op1 = b;    // larger number becomes first operand
                op2 = this;
            }

            int a = 0;
            int carry = 0;
            var products = new List<InfInt>(); // list of products which will be summed
            var zero = op2.digits.Count - 1;   // used for adding 0s to products for correct addition
            for (int i = 0; i<op2.digits.Count; i++)
            {
                var number = new InfInt();
                for (int j = (op1.digits.Count - 1); j >= 0; j--)
                {
                    if (j==0 && carry !=0) // last digit of first operand
                    {
                        a = op1.digits[j] * op2.digits[i] + carry;
                        number.digits.Add(a % 10);
                        number.digits.Add(a/10);
                        carry = 0;
                    }
                    else
                    {
                        a = (op2.digits[i]*op1.digits[j] + carry);   
                        carry = op2.digits[i] * op1.digits[j] / 10;  // 5*5 / 10 = 2
                        number.digits.Add(a % 10);
                    }                                      
                }                
                number.digits.Reverse();
                // carry for sum of last digits if >= 10
                for (int j = 0; j < zero; j++)
                {
                    number.digits.Add(0);
                }
                zero--; // decrement number of zeros added at the end of product
                products.Add(number); // list of infints (products) to be summed  
            }                     
            var result = new InfInt();
            for(int i=0; i<products.Count; i++)
            {
                result = result.AddDigits(products[i]); // add products
            }            
            return result.ToString();
        }
        // Multiplies Infints and determins the sign of product
        public string Times(InfInt b)
        {
            var result = "";
            var sign = "";
            if (this.sign == b.sign) // --- or -+
            {
                result = this.MultiplyDigits(b);
            }
            else
            {
                result = this.MultiplyDigits(b);
                sign = "-";
            }
            // using int.Parse to avoid many 0s    M I S T A K E   ! ! !
            return sign + (int.Parse(result.ToString())).ToString();
        }

        // overriding ToString()
        public override string ToString()
        {
            string number = "";
            for (int i = 0; i < this.digits.Count; i++)
            {
                number += "" + (digits[i].ToString()); // turn InfInt value into a String
            }
            // add sign to the string 
            return (sign == true) ? " -" + number + " " : " " + number + " ";
        }
    }
}