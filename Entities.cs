using System;

namespace Fibonacci {
    internal class Entities {

        public int N { get; set; }

        public Entities(int n) { 
            
            N = n;
        }
        public Entities() { }

        public void Fibonacci(int n) {
            int a = 0;
            int b = 1;
            int c;
            
            for (int i = 1; i <= n; i++) {
                                
                c = a + b;
                b = a;
                a = c;
                                             
            }

            N = a;
      
        }

        public override string ToString() {

            return N.ToString();

        }

    }
}
