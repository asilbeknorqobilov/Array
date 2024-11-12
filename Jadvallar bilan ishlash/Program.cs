// Array 1
// int n, s = -1;
// Console.WriteLine("Massiv o'lchamini kiriting:");
// n = Convert.ToInt32(Console.ReadLine());
// int[] a = new int[n];
// for (int i = 0; i < n; i++)
// {
//     s += 2;
//     a[i] = s;
// }
// for (int i = 0; i < n; i++)
// {
//     Console.WriteLine(a[i]);
// }
//
//
// Array 2
// int n, s = 1;
// Console.WriteLine("Massiv o'lchamini kiriting:");
// n = Convert.ToInt32(Console.ReadLine());
// int[] a = new int[n];
// for (int i = 0; i < n; i++)
// {
//     s *= 2;
//     a[i] = s;
// }
// for (int i = 0; i < n; i++)
// {
//     Console.WriteLine(a[i]);
// }
//
//
// Array 3
// int n, a1 = 0, d = 3;
// Console.WriteLine("Massiv o'lchamini kiriting");
// n =  Convert.ToInt32(Console.ReadLine());
// int[] a = new int[n];
// for (int i = 0; i < n; i++)
// {
//     a1 += d;
//     a[i] = a1;
// }
// for (int i = 0; i < n; i++)
// {
//     Console.WriteLine(a[i]);
// }
//
//
// Array 7
// int n;
// Console.WriteLine("Massiv elementlari sonini kiriting:");
// n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(string.Format("{0} ta butun son kiriting:", n));
// int[] a = new int[n];
// for (int i = 0; i < n; i++)
// {
//     string z;
//     z= Console.ReadLine();
//     a[i] = Convert.ToInt32(z);
// }
//
// for (int i = n - 1; i >= 0; i--)
// {
//     Console.WriteLine(a[i]);
// }
//
//
// Array 8
// int n, c = 0;
// int[] a = new int[6] { 4, 5, 7, 8, 6, 9 };
// for (int i = 0; i < 6; i++)
// {
//     if (a[i] % 2 == 1)
//     {
//         c++;
//         Console.WriteLine(a[i]);
//     }
// }
// Console.WriteLine(c);
//
//
// Array 9
// int c = 0;
// int[] a = new int[6] { 4, 5, 7, 8, 6, 9 };
// for (int i = 0; i < 6; i++)
// {
//     if (a[i] % 2 == 0)
//     {
//         c++;
//         Console.WriteLine(a[i]);
//     }
// }
//
//
// Array 10
// int c = 0, d = 0;
// int[] a = new int[6] { 4, 5, 7, 8, 6, 9 };
// for (int i = 0; i < 6; i++)
// {
//     if (a[i] % 2 == 0)
//     {
//         c++;
//         Console.WriteLine(a[i]);
//     }
// }
// for (int i = 0; i < 6; i++)
// {
//     if (a[i] % 2 == 1)
//     {
//         c++;
//         Console.WriteLine(a[i]);
//     }
// }
//
//
// Array 11
// int n=10, k=2, d = 0;
// int[] a = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
// for (int i = k; i < 10; i+=k)
// { 
//     Console.WriteLine(a[i]);
// }
//
//
// Array 12
// int n;
// Console.WriteLine("Massiv elementlari sonini kiriting:");
// n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(string.Format("{0} ta butun son kiriting",n));
// int[] a = new int[n];
// for (int i = 0; i < n; i++)
// {
//     string z;
//     z = Console.ReadLine();
//     a[i] = Convert.ToInt32(z);
// }
// Console.WriteLine("Natija:");
// for (int j = 0; j < n; j += 2)            
// {
//     Console.WriteLine(a[j]);
// }
//
//
// Array 13
// int n = 7;
// Console.WriteLine("Massiv elementlari sonini kiriting:");
// n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(string.Format("{0} ta butun son kiriting", n));
// int[] a = new int[n] ;
// for (int i = 0; i < n; i++)
// {
//     string z;
//     z = Console.ReadLine();
//     a[i] = Convert.ToInt32(z);
// }     
// Console.WriteLine("Natija:");
// for (int j = n - 2; j > 0; j -= 2) 
// {
//     Console.WriteLine(a[j]);
// }
//
//
// Array 14
// int n = 6;
// int[] a = new int[6] { 0, 1, 2, 3, 4, 5 };
// for (int i = 0; i < n; i+=2)
// {
//     Console.WriteLine(a[i]);
// }
// Console.WriteLine("Keyin");    
// for (int i = n-1; i >= 0; i -= 2)
// {
//     Console.WriteLine(a[i]); 
// }
//
//
// Array 15
// int n = 6;
// int[] a = new int[6] { 0, 1, 2, 3, 4, 5 };
// for (int i = 1; i < n; i += 2)
// {
//     Console.WriteLine(a[i]);
// }
// Console.WriteLine("Keyin");
// for (int i = n - 2; i >= 0; i -= 2)
// {
//     Console.WriteLine(a[i]);
// }
//
//
// Array 16
// int n = 6;
// int[] a = new int[] { 0, 1, 2, 3, 4, 5, 6};
// for  (int i = 0; i < n/2; i++)
// {
//     Console.WriteLine(a[i]);
//     Console.WriteLine(a[n - 1 - i]);
// }
// if (n % 2 == 1)
// {
//     Console.WriteLine(n / 2 );
// }
// else 
// {
//     return;
// }
//
//
// Array 17
// int n = 10, c = 0;
// int[] a = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
// for (int i = 0; i < n / 4; i++)
// {
//     Console.WriteLine(a[c]);
//     Console.WriteLine(a[c+1]);
//     Console.WriteLine(a[n - 1 - c]);
//     Console.WriteLine(a[n - 2 - c]);
//     c =+ 2;
// }
// if (n % 2 == 1)
// {
//     Console.WriteLine(a[c+3]);
// }
// else
// {
//     return;
// }
//
//
// Array 18
// int n = 5, x = 0;
// int[] a = new int[] { 31, 12, 26, 34, 4 };
// for (int i = 0; i < n; i++)
// {
//     if (a[i] < a[n - 1])
//     {
//         x = a[i];
//         break;
//     }
// }
//
// Console.WriteLine(x);
//
//
// Array 19
// int n = 8, x = 0;
// int[] a = new int[] { 2, 1, 2, 3, 4, 15, 61, 7 };
// for (int i = 0; i < n; i++)
// {
//     if (a[0] < a[i] && a[n - 1] > a[i]) 
//     {
//         x = a[i];
//     }
// }
// Console.WriteLine(x);
//
//
// Array 20
// int n = 8, k = 3, l = 4, s = 0;
// int[] a = new int[] { 2, 1, 2, 3, 4, 15, 61, 7 };
// for (int i = k + 1; i < l; i++)
// {
//     s += a[i];
// }
// Console.WriteLine(s);
//
//
// Array 21
// int n = 8, k = 3, l = 7;
// double s = 0;
// int[] a = new int[] { 2, 1, 2, 3, 4, 15, 61, 7 };
// for (int i = k + 1; i < l; i++)
// {
//     s += a[i];
// }
// Console.WriteLine(s/(l-1-k));
//
//
// Array 22
// int n = 8, k = 3, l = 7;
// double b = 0, c = 0, s;   
// int[] a = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
// for (int j = 0; j < n; j++)
// {
//     b += a[j];
// }
// for (int i = k + 1; i < l; i++)
// {
//     c += a[i];
// }
// s = b - c;
// Console.WriteLine((s));
//
//
// Array 23
// int n = 8, k = 3, l = 4;
// double b = 0, c = 0, s;
// int[] a = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
// for (int j = 0; j < n; j++)
// {
//     b += a[j];
// }
// for (int i = k + 1; i < l; i++)
// {
//     c += a[i];
// }
// s = b - c;
// Console.WriteLine(s / (n - (l - k - 1)));
//
//
// Array 24
// using System.Reflection.Metadata;
//
// int n = 8, d;
// double x = .0;
// bool check = true;
// int[] a = new int[] { 0, 1, 2, 3, 4, 6, 6, 7 };
// d = a[1] - a[0];
// for (int j = 1; j < n; j++)
// {
//     check = check && (d == a[j] - a[j - 1]);
// }
//
// if (check)
// {
//     Console.WriteLine(d);
// }
// else
// {
//     Console.WriteLine(0);
// }
//
// double a, p;
// Console.WriteLine("To'rtburchak tomonini kirgazing:");
// a = Convert.ToDouble(Console.ReadLine());
// p = 4 * a;
// Console.WriteLine(p);
//
//
// Array 25
// int n = 8, d;
// double x = 0;
// bool check = true;
// int[] a = new int[] { 2, 4, 8, 16, 32, 64, 128, 256 };
// d = a[1] / a[0];
// for (int j = 1; j < n; j++)
// {
//     check = check && (d == a[j] / a[j - 1]);
// }
//
// if (check)
// {
//     Console.WriteLine(d);
// }
// else
// {
//     Console.WriteLine(0);
// }
//
//
// Array 26
// int n = 8, k = 3, l = 4;
// double b = 0, c = 0, s;
// int[] a = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
// for (int j = 0; j < n; j++)
// {
//     b += a[j];
// }
// for (int i = k + 1; i < l; i++)
// {
//     c += a[i];
// }
// s = b - c;
// Console.WriteLine(s / (n - (l - k - 1)));
//
//
// Array 27
// int n = 8;
// double b = 0, c = 0, s;
// int[] a = new int[] { 5, -1, -2, -3, 4, -5, 6, -7 };
// bool wifi = true;
// b = a[n - 1] * a[n - 2];
// for (int i = 0; i < n-1; i++) 
// {
//     wifi = wifi && ( 0 > a[i] * a[i + 1]);
// }
// if (wifi)
// {
//     Console.WriteLine(0);
// }
// else
// {
//     Console.WriteLine(b);
// }
//
//
// Array 28
// int n = 6, x, minim;
// int[] a = new int[] { 9, 2, 3, 4, 5, 6 };
// minim = a[0];
// for (int i = 1; i < n; i += 2) 
// {
//     if (minim > a[i])
//     {
//         minim = a[i];
//     }
// }
// Console.WriteLine(minim);
//
//
// Array 29
// int n = 10, max;
// int[] a = new int[] { 12, 5, 7, 5, 8, 9, 2, 4, 1, 17 };
// max = a[1];
// for (int i = 1; i < n; i += 2) 
// {
//     if (max < a[i])
//     {
//         max = a[i];
//     }
// }
// Console.WriteLine(max);
//
//
// Array 30
// int n = 6, x=0;
// int[] a = new int[] { 2, 3, 12, 5, 6, 7 };
// for (int i = 0; i < n-1; i++)
// {
//     if (a[i] < a[i + 1])
//     {
//         Console.WriteLine(a[i]);
//         x++;
//     }
// }
// Console.WriteLine(x);
//
//
// Array 31
// int n = 7, x = 0;
// int[] a = new int[] { 0, 1, 2, 3, 4, 5, 6};
// for (int i = n-1; i > 0; i--)
// {
//     if (a[i-1] < a[i])
//     {
//         Console.WriteLine(a[i]);
//         x++;
//     }
// }
// Console.WriteLine(x);
//
//
// Array 32
// int n = 7, x = 0;
// int[] a = new int[] { 0, 3, 2, 5, 4, 5, 6 };
// for (int i = 1; i < n-2; i++)
// {
//     if (a[i - 1] < a[i] && a[i] > a[i + 1]) 
//     {
//         Console.WriteLine(a[i]);
//         x++;
//     }
// }
// Console.WriteLine(x);
//
//
// Array 33
// int n = 7, x = 0;
// int[] a = new int[] { 0, 3, 2, 5, 4, 5, 6 };
// for (int i = 1; i < n - 2; i++)
// {
//     if (a[i - 1] < a[i] && a[i] > a[i + 1])
//     {
//         x = (a[i]);
//     }
// }
// Console.WriteLine(x);
//
//
// Array 34
// int n = 6, max;
// int[] a = new int[] { 7, 2, 3, -4, 5, 16 };
// max = -99999999;
// for (int i = 1; i < n-2; i++)
// {
//     if (a[i - 1] > a[i] && a[i + 1] > a[i])
//     {
//         //Console.WriteLine(a[i]);
//         if (max < a[i])
//         {
//             max = a[i];
//         }
//     }
// }
// Console.WriteLine(max);
//
//
// Array 35
// int n = 6, max;
// int[] a = new int[] { 7, 2, 3, -4, 5, 16};
// max = 99999999;
// for (int i = 1; i < n - 2; i++)
// {
//     if (a[i - 1] < a[i] && a[i + 1] < a[i])
//     {
//         //Console.WriteLine(a[i]);
//         if (max > a[i])
//         {
//             max = a[i];
//         }
//     }
// }l        
// Console.WriteLine(max);
//
//
// Array 36
// int s;
// double x = 12.4983189498834981;   
// s = Convert.ToInt32(x);
// Console.WriteLine(s);
// for (int i = 1; i < n - 2; i++)
// {
//     if (a[i - 1] < a[i] && a[i + 1] < a[i])
//     {     
//         //Console.WriteLine(a[i]);
//         if (max > a[i])
//         {
//             max = a[i];
//         }
//     }
// }
// Console.WriteLine(max);
//
//
//  Array 37
//  int n = 17, c = 0, x = 0;
//  int[] a = new int[] { 0, 1, 2, 3, 4, 5, 4, 6, 7, 8, 1, 4, 6, 2, 3, 1, 2 };
//  for (int i = 0; i < n-1; i++)
//  {
//      //Console.Write(a[i]);
//      //Console.WriteLine(a[i+1]);
//      if ( a[i] < a[i + 1] ) 
//      {
//          c++;
//      }
//      else if(c>0)
//      {
//          x++;
//          c = 0;
//      }
//  }
//  if ( c > 0 )
//  {
//      Console.WriteLine(x+1);
//  }
//  else
//  {
//      Console.WriteLine(x);
//  }
//
//
//  // Array 38
//  int n = 17, c = 0, x = 0;
//  int[] a = new int[] { 0, 1, 2, 3, 4, 5, 4, 6, 7, 8, 1, 4, 6, 2, 3, 1, 2 };
//  for (int i = n - 1; i > 0; i--) 
//  {
//      //Console.Write(a[i]);
//      //Console.WriteLine(a[i+1]);
//      if (a[i] > a[i + 1])
//      {
//          c++;
//      }
//      else if (c > 0)
//      {
//          c = 0;
//      }
//  }
//  if (c > 0)
//  {
//      Console.WriteLine(x + 1);
//  }
//  else
//  {
//      Console.WriteLine(x);
//  }
//
//  Array 40
//
//  int n = 5, r = 6, c, x;
//  int[] a = new int[] { 1, 7, 3, 4, -1 };
//  int max = Math.Abs(a[0] - r);
//  x = a[0];
//  for (int i = 1; i < n; i++)
//  {
//      c = Math.Abs(a[i] - r);
//      if (max > c)
//      {
//          max = c;
//          x = a[i];
//      }
//  }
//
//  Console.WriteLine(x);
//
//
//  Array 41
//
//  int n = 6, s;
//  int x = 0, y = 0;
//  int[] a = new int[] { 1, 2, 3, 7, 5, 6 };
//  int max = a[0] + a[1];
//  for (int i = 1; i < a.Length - 2; i++)
//  {
//      s = a[i] + a[i + 1];
//      if (max < s)
//      {
//          max = s;
//          x = a[i];
//          y = a[i + 1];
//      }
//  }
//
//  Console.WriteLine(x);
//  Console.WriteLine(y);
//
//
//  Array 42
//  int r = 10;
//  int x = 0, y = 0, c, z;
//  int[] a = new int[] { 5, 6, 7, 8, 9 };
//  int s = Math.Abs(a[0] + a[1] - r);
//  for (int i = 1; i < a.Length - 2; i++)
//  {
//      c = Math.Abs(a[i] + a[i + 1] - r);
//      if (s >= c) ;
//      {
//          s = c;
//          x = a[i];
//          y = a[i + 1];
//      }
//      if (s < c) 
//      {
//          x = a[0];
//          x = a[1];
//      }
//      
//  }
//
//  Console.WriteLine(x);
//  Console.WriteLine(y);
//
//
//  Array 43
//
//  int s = 0;
//  int[] a = new int[] { 1, 2, 3, 3, 3, 4, 4, 5, 6, 7, 7, 8, 8 };
//  for (int i = 0; i < a.Length - 1; i++)
//  {
//      if (a[i] != a[i + 1])
//      {
//          Console.WriteLine(a[i]);
//          s++;
//      }
//  }
//
//  Console.WriteLine(s + 1);
//
//
//  Array 44
//
//  int s = 0;
//  int[] a = new int[] { 1, 2, 3, 3, 4, 4, 5, 6, 7, 7, 8, 8 };
//  for (int i = 0; i < a.Length - 1; i++)
//  {
//      if (a[i] == a[i + 1])
//      {
//          Console.WriteLine(i);
//          Console.WriteLine(i + 1);
//      }
//  }
//
//  Array 45
//
//  int[] a = new int[] { 11, 2, 3, 12, 5, 6, 7, 18, 8 };
//  int s = Math.Abs(a[0] - a[1]);
//  int c;
//  for (int i = 0; i < a.Length - 1; i++)
//  {
//      c = Math.Abs(a[i] - a[i + 1]);
//      if (s > c)
//      {
//          s = c;
//          Console.WriteLine(i);
//          Console.WriteLine(i+1);
//      }
//  }
//
//
//  Array 46
//
// int R = 14;
// int x = 0, y = 0;
// int[] a = new int[] { 5, 6, 7, 8, 9 };
// int s = a[0];
// for (int i = 1; i < a.Length - 2; i++)
// {
//     for (int j = 0; j < a.Length ; j++)
//     {
//         int sum = a[i] + a[j];
//         int farq = Math.Abs(R - sum);
//
//         if (farq < Math.Abs(R - s))
//         {
//             s = sum;
//             x = a[i];
//             y = a[j];
//         }
//     }
// }
//
// Console.WriteLine(x);
// Console.WriteLine(y);


// Array 47

// int[] a = new int[] { 5, 6, 6, 8, 7, 8, 9,9,0,9,9,0,9,9,12 };
// int[] cashe = new int[a.Length];
// Console.WriteLine(cashe);
// int nat = 0, c = 0;
// bool has_zero = a.Contains(0);
// for (int i = 0; i < a.Length; i++)
// {
//     if (!cashe.Contains(a[i]) || (a[i]==0 && has_zero))
//     {
//         cashe[c] = a[i];
//         c++;
//         Console.WriteLine(a[i]);
//         if (a[i] == 0)
//             has_zero = false;
//     }
// }


// Array 48
// int[] a = new int[] { 5, 6, 6, 8, 7, 8, 9, 8 };
// int nat = 0;
// for (int i = 1; i < a.Length; i++)
// {
//     for (int j = 0; j < a.Length; j++)
//     {
//         if (a[i] == a[j])
//         {
//             nat++;
//         }
//     }
// }
//
// Console.WriteLine(nat);


//  // Array 49
//  int n = 17, c = 0, x = 0;
//  int[] a = new int[] { 0, 1, 2, 3, 4, 5, 4, 6, 7, 8, 1, 4, 6, 2, 3, 1, 2 };
//  for (int i = n - 1; i > 0; i--) 
//  {
//      //Console.Write(a[i]);
//      //Console.WriteLine(a[i+1]);
//      if (a[i] > a[i + 1])
//      {
//          c++;
//      }
//      else if (c > 0)
//      {
//          c = 0;
//      }
//  }
//  if (c > 0)
//  {
//      Console.WriteLine(x + 1);
//  }
//  else
//  {
//      Console.WriteLine(x);
//  }


// Array 50

// int[] a = new int[] { 0, 2, 4, 3, 5, 8, 6 };
// int nat = 0;
// for (int i = 0; i < a.Length - 1; i++)
// {
//     if (a[i] > a[i + 1]) 
//     {
//         nat++;
//     }
// }
//
// Console.WriteLine(nat);


// Array 51
//
// int[] a = new int[] { 5, 6, 6, 8, 7, 8, 9, 8 };
// int nat = 0;
// for (int i = 1; i < a.Length; i++)
// {
//     for (int j = 0; j < a.Length; j++)
//     {
//         if (a[i] == a[j])
//         {
//             nat++;
//         }
//     }
// }
//
// Console.WriteLine(nat);


//Array 52

// int R = 14;
// int x = 0, y = 0;
// int[] a = new int[] { 5, 6, 7, 8, 9 };
// int s = a[0];
// for (int i = 1; i < a.Length - 2; i++)
// {
//     for (int j = 0; j < a.Length ; j++)
//     {
//         int sum = a[i] + a[j];
//         int farq = Math.Abs(R - sum);
//
//         if (farq < Math.Abs(R - s))
//         {
//             s = sum;
//             x = a[i];
//             y = a[j];
//         }
//     }
// }
//
// Console.WriteLine(x);
// Console.WriteLine(y);


// Array 54

//  int n = 17, c = 0, x = 0;
//  int[] a = new int[] { 0, 1, 2, 3, 4, 5, 4, 6, 7, 8, 1, 4, 6, 2, 3, 1, 2 };
//  for (int i = n - 1; i > 0; i--) 
//  {
//      //Console.Write(a[i]);
//      //Console.WriteLine(a[i+1]);
//      if (a[i] > a[i + 1])
//      {
//          c++;
//      }
//      else if (c > 0)
//      {
//          c = 0;
//      }
//  }
//  if (c > 0)
//  {
//      Console.WriteLine(x + 1);
//  }
//  else
//  {
//      Console.WriteLine(x);
//  }

// Array 55

// int[] a = new int[] { 0, 1, 2, 3, 4, 5 };
// int n = 0;
// if (a.Length % 2 == 0)
// {
//     n = a.Length / 2 + 1;
// }
//
// if (a.Length % 2 == 1)
// {
//     n = a.Length / 2 + 1;
// }
// int[] b = new int[n];
// int sanovchi = 0;
// int j = 0;
// for (int i = 1; i < a.Length - 1; i += 2) 
// {
//     j++;
//     b[j] = a[i];
//     Console.WriteLine(b[j]);
//     sanovchi++;
// }
//
// Console.WriteLine("Elementlar soni:");
// Console.WriteLine(sanovchi);

// Array 56

// int[] a = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
// int n = Convert.ToInt32(a.Length / 3);
// int[] b = new int[n];
// int sanovchi = 0;
// int j = -1;
// for (int i = 3; i < a.Length ; i += 3)
// {
//     j++;
//     b[j] = a[i];
//     Console.WriteLine(b[j]);
//     sanovchi++;
// }
//
// Console.WriteLine("Elementlar soni:");
// Console.WriteLine(sanovchi);


// Array 57

// int[] a = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
// int n = Convert.ToInt32(a.Length);
// int[] b = new int[n];
// int j = 0;
// for (int i = 1; i < a.Length ; i += 2)
// {
//     b[j] = a[i];
//     Console.WriteLine(b[j]);
//     j++;
// } 
//
// for (int i = 0; i < a.Length ; i += 2)
// {
//     b[j] = a[i];
//     Console.WriteLine(b[j]);
//     j++;
// }


// Array 58

// int[] a = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
// int n = Convert.ToInt32(a.Length);
// int[] b = new int[n];
// int j = 0;
// int s = 0;
// for (int i = 0; i < a.Length ; i++)
// {
//     s += a[i];
//     b[j] = s;
//     Console.WriteLine(b[j]);
//     j++;
// }


// Array 59

// int[] a = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
// int n = Convert.ToInt32(a.Length);
// double[] b = new double[n];
// double s = 0;
// b[0] = a[0];
// Console.WriteLine(b[0]);
// for (int i = 1; i < a.Length; i++)
// {
//     s += a[i];
//     b[i] = Convert.ToInt32(s / (i + 1));
//     Console.WriteLine(b[i]);
// }


// Array 60

// int[] a = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
// int n = Convert.ToInt32(a.Length);
// int[] b = new int[n];
// int j = 0;
// int s = 0;
// for (int i = 0; i < a.Length ; i++)
// {
//     s += a[i];
// }
//
// for (int i = 0; i < a.Length ; i++)
// {
//     s -= a[i];
//     b[j] = s;
//     Console.WriteLine(b[j]);
//     j++;
// }


// Array 61

// int[] a = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
// int n = Convert.ToInt32(a.Length);
// int[] b = new int[n];
// int j = 0;
// double s = 0;
// for (int i = 0; i < a.Length ; i++)
// {   
//     s += Convert.ToDouble(a[i]);
// }
//
// for (int i = 0; i < a.Length ; i++)
// {
//     s -= Convert.ToDouble(a[i]);
//     b[j] = s / i;
//     Console.WriteLine(b[j]);
//     j++;
// }


// Array 62
//
// int[] a = new int[] { 0, -1, 2, -3, 4, -5, 6, -7 };
// int n = Convert.ToInt32(a.Length);
// int[] b = new int[n];
// int[] c = new int[n];
// int ci = 0, bi = 0;
// Console.WriteLine("massiv b");
// for (int i = 0; i < a.Length; i++) 
// {
//     if (a[i] >= 0)
//     {
//         b[i] = a[i];
//         Console.WriteLine(b[i]);
//         bi++;
//     }
// }
// Console.WriteLine($"B massiv elementlar soni {bi} ta");
//
// Console.WriteLine("massiv c");
// for (int i = 0; i < a.Length; i++) 
// {
//     if (a[i] < 0) 
//     {
//         c[i] = a[i];
//         Console.WriteLine(c[i]);
//         ci++;
//     }
// }
// Console.WriteLine($"C massiv elementlar soni {ci} ta");


// Array 63

// int[] a = new[] { 1, 2, 3, 4, 5 };
// int[] b = new[] { 6, 7, 8, 9, 10 };
// int[] c = new int[a.Length + b.Length];
// int j = 0;
// for (int i = 0; i < (c.Length) / 2; i++)
// {
//     c[i] = a[i];
//     Console.WriteLine(c[i]);
// }
//
// for (int i = Convert.ToInt32((c.Length) / 2); i < c.Length; i++) 
// {
//     c[i] = b[j];
//     Console.WriteLine(c[i]);
//     j++;
// }


// Array 64

// int[] a = new[] { 1, 2, 3, 4, 5 };
// int[] b = new[] { 6, 7, 8, 9, 10 };
// int[] c = new[] { 11, 12, 13, 14, 15 };
// int[] d = new int[a.Length + b.Length + c.Length];
// int j = 0, k = 0;
// for (int i = 0; i < (d.Length) / 3; i++)
// {
//     d[i] = a[i];
//     Console.WriteLine(d[i]);
// }
//
// for (int i = Convert.ToInt32((d.Length) / 3); i < 2 * d.Length / 3; i++)
// {
//     d[i] = b[j];
//     Console.WriteLine(d[i]);
//     j++;
// }
//
// for (int i = Convert.ToInt32((2 * d.Length) / 3); i < d.Length; i++)
// {
//     d[i] = c[k];
//     Console.WriteLine(d[i]);
//     k++;
// }


// Array 65
//
// int[] a = new int[] { 1, 2, 3, 4, 5 };
// int k = 2;
// int j = 0;
// int m = a[k];
// for (int i = 0; i < a.Length; i++)
// {
//     a[j] = (a[i] + m);
//     Console.WriteLine(a[j]);
//     j++;
// }


// Array 66

// int[] a = new int[] { 1, 7, 3, 9, 5 };
// int k = 2;
// for (int i = 0; i < a.Length; i++)
// {
//     if (a[i] % 2 == 0)
//     {
//         a[i] = a[i] + k;
//         k += 2;
//     }
//     Console.WriteLine(a[i]);
// }


// Array 67

// int[] a = new int[] { 1, 7, 3, 9, 5 };
// int k = 0;
// for (int i = 0; i < a.Length; i++)
// {
//     if (a[i] % 2 == 1)
//     {
//         k = a[i];
//     }
// }
//
// for (int i = 0; i < a.Length; i++)
// {
//     if (a[i] % 2 == 1)
//     {
//         a[i] = a[i] + k;
//     }
//     Console.WriteLine(a[i]);
// }


// Array 68

// int[] a = new int[] { 1, 7, 3, 9, 5 };
// int max = a[0], min = a[0];
// int i1=0,i2 = 0;
// for (int i = 0; i < a.Length; i++)
// {
//     if (max < a[i])
//     {
//         max = a[i];
//         i1 = i;
//     }
//     if (min > a[i])
//     {
//         min = a[i];
//         i2 = 1;
//     }
// }
//
// int j = 0;
// for (int i = 0; i < a.Length; i++)
// {
//     a[j] = a[i];
//     if (j == i1)
//     {
//         a[j] = min;
//     }
//     if (j == i2)
//     {
//         a[j] = max;
//     }
//
//     Console.WriteLine(a[j]);
//     j++;
// }


// Array 69
//
// int[] a = new[] { 0, 1, 2, 3, 4, 5 };
// int j = 0;
// for (int i = 0; i < a.Length; i++)
// {
//     if (i % 2 == 0)
//     {
//         a[i] = a[i + 1];
//         Console.WriteLine(a[i]);
//     }
//     if (i % 2 != 0)
//     {
//         a[i] = a[i - 1];
//         Console.WriteLine(a[i]);
//     }
// }

// Array 70

// int[] a = new int[] { 1, 7, 3, 9, 5 };
// int max = a[0], min = a[0];
// int i1=0,i2 = 0;
// for (int i = 0; i < a.Length; i++)
// {
//     if (max < a[i])
//     {
//         max = a[i];
//         i1 = i;
//     }
//     if (min > a[i])
//     {
//         min = a[i];
//         i2 = 1;
//     }
// }
//


// Array 71

// int[] a = new[] { 0, 1, 2, 3, 4, 5 };
// int[] b = new int[a.Length];
//
// int j = a.Length / 2;
// for (int i = 0; i < a.Length / 2; i++)
// {
//     if (i < a.Length / 2)
//     {
//         b[i] = a[a.Length / 2 + i];
//         Console.WriteLine($"{i} -element {b[i]} ga teng");
//     }
// }
// for (int i = a.Length / 2; i < a.Length; i++)
// {
//     if (i >= a.Length / 2)
//     {
//         b[i] = a[a.Length / 2 - j];
//         Console.WriteLine($"{i} -element {b[i]} ga teng");
//         j--;
//     }
// }

// Array 72
//
// int c = 0, x;
// int[] a = new int[] { 0, 1, 2, 3, 4, 5, 6 };
// int n = a.Length;
// int k = 1, h = 5;
// for (int i = k; i < h + 1; i++)
// {
//     x = a[i];
//     a[i] = a[h - c];
//     a[h - c] = x;
//     if (i == h - c)
//     {
//         break;
//     }
//     c++;
// }
// foreach (int ai in a)
// {
//     Console.WriteLine(ai);
// }

// matn 

// bool check(string a,string b)
// {
//     return a == b;
// }
// string s = "Assalom salom mening ismim Asilbek,salom Asilbek Assalom";
//
// s = s.Replace(',', ' ');
// string[] x = s.Split(' ');
// string[] trash = new string[x.Length];
// int ti = 0;
// foreach (string xi in x)
// {
//     int z = x.Count(c => c == xi);
//     if (z > 1 && !trash.Contains(xi)) 
//     {
//         Console.WriteLine(xi);
//         trash[ti] = xi;
//         ti++;
//     }
// }

// int Count(string[] s, Func<string, bool> predicate)
// {
//     int res = 0;
//     for (int i = 0; i < s.Length; i++)
//         if (predicate(s[i]))
//             res++;
//     return res;
// }
//
// Console.WriteLine(Count(x, c=>c=="Asilbek"));

// Array 73

// int c = 1, x;
// int[] a = new int[] { 0, 1, 2, 3, 4, 5, 6 };
// int n = a.Length;
// int k = 1, h = 5;
// for (int i = k + 1; i < h; i++) 
// {
//     x = a[i];
//     a[i] = a[h - c];
//     a[h - c] = x;
//     if (i == h - c)
//     {
//         break;
//     }
//
//     c++;
// }
//
// foreach (int ai in a)
// {
//     Console.WriteLine(ai);
// }


// Array 74

// int[] a = new int[] { 8, 4, 9, 12, 4, 17, 6 };
// int max = a[0];
// int min = a[0];
// int imax = 0, imin = 0;
// for (int i = 0; i < a.Length; i++)
// {
//     if (a[i] > max)
//     {
//         max = a[i];
//         imax = i;
//     }
//     if (a[i] < min)
//     {
//         min = a[i];
//         imin = i;
//     }
// }
//
// for (int i = imin + 1; i < imax; i++) 
// {
//     a[i] = 0;
// }
// foreach (int massiv in a)
// {
//     Console.WriteLine(massiv);
// }

// Array 75

// int[] a = new int[] { 2, 1, 9, 12, 4, 17, 6 };
// int max = a[0];
// int min = a[0];
// int imax = 0, imin = 0;
// for (int i = 0; i < a.Length; i++)
// {
//     if (a[i] > max)
//     {
//         max = a[i];
//         imax = i;
//     }
//     if (a[i] < min)
//     {
//         min = a[i];
//         imin = i;
//     }
// }
//
// int i1, i2;
// if (imax > imin) 
// {
//     i1 = imin;
//     i2 = imax;
// }
// else
// {
//     i1 = imax;
//     i2 = imin;
// }
//
// int c = 0 ,x;
// for (int i = i1; i <= i2; i++)
// {
//     x = a[i];
//     a[i] = a[i2 - c];
//     a[i2 - c] = x;
//     if (i == i2 - c)
//     {
//         break;
//     }
//
//     c++;
// }
// foreach (int massiv in a)
// {
//     Console.WriteLine(massiv);
// }


// Array 76

// int c = 1, x;
// int[] a = new int[] { 0, 1, 2, 3, 4, 5, 6 };
// int n = a.Length;
// int k = 1, h = 5;
// for (int i = k + 1; i < h; i++) 
// {
//     x = a[i];
//     a[i] = a[h - c];
//     a[h - c] = x;
//     if (i == h - c)
//     {
//         break;
//     }
//
//     c++;
// }
//
// foreach (int ai in a)
// {
//     Console.WriteLine(ai);
// }


// Array 77

// int[] a = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
// int n = Convert.ToInt32(a.Length);
// int[] b = new int[n];
// int j = 0;
// double s = 0;
// for (int i = 0; i < a.Length ; i++)
// {   
//     s += Convert.ToDouble(a[i]);
// }
//
// for (int i = 0; i < a.Length ; i++)
// {
//     s -= Convert.ToDouble(a[i]);
//     b[j] = s / i;
//     Console.WriteLine(b[j]);
//     j++;
// }

// Array 78

// int R = 14;
// int x = 0, y = 0;
// int[] a = new int[] { 5, 6, 7, 8, 9 };
// int s = a[0];
// for (int i = 1; i < a.Length - 2; i++)
// {
//     for (int j = 0; j < a.Length ; j++)
//     {
//         int sum = a[i] + a[j];
//         int farq = Math.Abs(R - sum);
//
//         if (farq < Math.Abs(R - s))
//         {
//             s = sum;
//             x = a[i];
//             y = a[j];
//         }
//     }
// }
//
// Console.WriteLine(x);
// Console.WriteLine(y);

// Array 79

// int[] a = new int[] {1, 2, 3, 4, 5 };
// int c = 0;
// int j = 1;
// for (int i = 0; i < a.Length; i++)
// {
//     Console.WriteLine(c);
//     c = a[j - 1];
//     j++;
// }


// Array 80

// int[] a = new int[] {1, 2, 3, 4, 5 };
// int n = a.Length;
// for (int i = 1; i < a.Length; i++)
// {
//     a[n - i] = a[n - i - 1];
//     Console.WriteLine(a[n - i]);
// }


// Array 81


// int[] a = new int[] { 1, 2, 3, 4, 5 };
// int k = 2;
// int n = a.Length;
// int m;
// for (int i = 0; i <= a.Length; i++)
// {
//     a[k + i] = a[i];
//     m = a[k + i];
//     Console.WriteLine(m);
//     if (i == k)
//     {
//         break;
//     }
// }


// Array 82

// int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7 };
// int k = 5;
// int n = a.Length;
// for (int i = k; i < n + k; i++)
// {
//     if (i < n)
//     {
//         a[i - k] = a[i];
//     }
//     else
//     {
//         a[i - k] = 0;
//     }
// }
//
// foreach (var x in a)
// {
//     Console.WriteLine(x);
// }


// Array 83

// int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7 };
// int n = a.Length;
// int an = a[n - 1];
// for (int i = n - 1; i > 0; i--)
// {
//     a[i] = a[i - 1];
// }
//
// a[0] = an;
// foreach (var nat in a)
// {
//     Console.WriteLine(nat);
// }


// Array 84
//
// int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7 };
// int n = a.Length;
// int oxirgi = a[0];
// for (int i = 2; i <= n; i++)
// {
//     a[i - 2] = a[i - 1];
// }
//
// a[n - 1] = oxirgi;
// foreach (var nat in a)
// {
//     Console.WriteLine(nat);
// }

// Array 85

// int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7 };
// int n = a.Length;
// int k = 2;
// for (int i = n - 1; i >= 0; i--)
// {
//     if (i < k)
//     {
//         a[i] = a[n - 1 - k];
//     }
// }
//     
// for (int i = n - 1; i >= k; i--)
// {
//     a[i] = a[i - k];
// }
//
// foreach (var nat in a)
// {
//     Console.WriteLine(nat);
// }


// Array 86

// int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7 };
// int n = a.Length;
// int k = 2;
// int oxirgi = a[0];
// for (int i = 0; i < k; i++)
// {
//     for (int j = n - 1; j > 0; j--)
//     {
//         a[j] = a[j - 1];
//     }
// }
//
// foreach (var nat in a)
// {
//     Console.WriteLine(nat);
// }


// Array 87

// int[] a = new int[] { 4, 2, 3, 5, 6, 7 };
// int bir = a[0];
// int j = 0;
// for (int i = 1; i < a.Length; i++)
// {
//     if (bir > a[i])
//     {
//         a[j] = a[i];
//     }
//
//     if (bir < a[i])
//     {
//         a[j] = bir;
//         break;
//     }
//
//     j++;
// }
//
//
// for (int p = j; p < a.Length; p++)
// {
//     a[j] = a[p];
//     j++;
// }
//
// foreach (var nat in a)
// {
//     Console.WriteLine(nat);
// }


// Array 88

// int[] a = new int[] {2, 3, 5, 6, 7, 4 };
// int n = a.Length;
// int oxirgi = a[n - 1];
// for (int i = n - 1; i > 0; i--)
// {
//     a[i] = a[i - 1];
// }
//
// a[0] = oxirgi;
//
// foreach (var nat in a)
// {
//     Console.WriteLine(nat);
// }


// Array 89

// int[] a = new int[] {2, 3, 5, 6, 7, 4 };
// int n = a.Length;
// int oxirgi = a[n - 1];
// for (int i = n - 1; i > 0; i--)
// {
//     a[i] = a[i - 1];
// }
//
// a[0] = oxirgi;
//
// foreach (var nat in a)
// {
//     Console.WriteLine(nat);
// }

//
// int[] a = new int[] { 2, 1, 5, 6, 7, 9 };
// int n = a.Length;
// int k;
// for (int i = 0; i < a.Length-1; i++)
// {
//     for (int j = i+1; j < a.Length; j++)
//     {
//         // Console.Write(a[i]);
//         // Console.Write(' ');
//         // Console.WriteLine(a[j]);
//         if (a[i] > a[j])
//         {
//             k = a[i];
//             a[i] = a[j];
//             a[j] = k;
//         }
//     }
// }


Console.WriteLine("So'zlar kiriting");
string a = Console.ReadLine();
string[] b = a.Split(' ', ',');
Console.WriteLine("a)");
for (int i = 0; i < b.Length; i++)
{
    bool c = true;
    for (int j = 0; j < b.Length; j++)
        if (i != j)
            if (b[i] == b[j])
                c = false;
    if (c)
    {
        Console.WriteLine(b[i]);
    }
}

Console.WriteLine("b)");
for (int i = 0; i < b.Length; i++)
{
    bool c = false;
    for (int j = i + 1; j < b.Length; j++)
    {
        if (b[i] == b[j])
            c = true;
    }

    if (c) 
    {
        Console.WriteLine(b[i]);
    }
}

Console.WriteLine("c)");
Array.Sort(b);
foreach (string s in b)
{
    Console.WriteLine(s);
}