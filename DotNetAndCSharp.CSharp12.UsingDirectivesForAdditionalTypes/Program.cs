

using ComplexNumber = (decimal Real, decimal Imaginary);



var complexNumber = new ComplexNumber { Real = 1.0m, Imaginary = 2.0m };


Console.WriteLine($"{complexNumber.Real} + {complexNumber.Imaginary}i");