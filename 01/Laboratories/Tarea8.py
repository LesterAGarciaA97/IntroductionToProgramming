__author__ = 'Lester'

def fibonacci(contador,n,p1,p2):
        var = ""
        if(contador!=n):
            var=fibonacci(contador+1,n,p1,p1+p2);
            var=str(p2)+""+var
        return var
n=int(input("Ingrese un numero entero\n"))
if(n>0):
         a=fibonacci(0,(n-1),0,1)
         print("0"+a)




