__author__ = 'Lester'

import Ejes;
import Estaciones;
import csv;

X=0
matriz=[[0,0,0,0,0],[0,0,0,0,0],[0,0,0,0,0],[0,0,0,0,0],[0,0,0,0,0],[0,0,0,0,0]]
def csv(self, path):
        c=0
        csv=open(path, "r")
        for row in csv:
            matriz[c][0]=row[0];
            matriz[c][1]=row[1];
            matriz[c][2]=row[2];
            matriz[c][3]=row[3];
            matriz[c][4]=row[4];
            matriz[c][5]=row[5];
            c+1;
        print("Datos cargados de forma correcta")


while (int(X) == 0):
    n = int(input("\n1.Administrador \n2.Usuario \n3.Salir \nProcedimiento que desea hacer?"))
    if n == 1:
        print("Bienvenido Administrador")
        password = input("Ingrese contraseña")
        if password == "72C078B565":

            X = input("Ingrese1 para cargar ejes, Ingrese2 para cargar estaciones")

        else:
            ("Ingrese correcta")


    elif (n == 2):
        print("Bienvenido Usuario")

    elif (n == 3):
        V = 1;

    else:
        print("Ingrese un valor valido")






