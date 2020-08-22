__author__ = 'Lester'

import Estaciones
class Ejes(object):
    def __init__(self, nombreEje):
        self.nombreEje = nombreEje
    def Estacion1(self):
        nombre=input("Ingrese el nombre de la estacion")
        siguiente=input("Ingrese el nombre de la estacion siguiente")
        precio=input("Ingrese el precio de la siguiente estacion")
        anteestacion=input("Ingrese el nombre de la estacion anterior")
        precioantes=input("Ingrese el precio de la estacion anterior")

        estacion = Estaciones.Estacion(nombre, siguiente,precio, anteestacion, precioantes)

    def Estacion2(self):
        nombre=input("Ingrese el nombre de la estacion")
        siguiente=input("Ingrese el nombre de la estacion siguiente")
        precio=input("Ingrese el precio de la siguiente estacion")
        anteestacion=input("Ingrese el nombre de la estacion anterior")
        precioantes=input("Ingrese el precio de la estacion anterior")

        estacion = Estaciones.Estacion(nombre, siguiente,precio, anteestacion, precioantes)

    def Estacion3(self):
        nombre=input("Ingrese el nombre de la estacion")
        siguiente=input("Ingrese el nombre de la estacion siguiente")
        precio=input("Ingrese el precio de la siguiente estacion")
        anteestacion=input("Ingrese el nombre de la estacion anterior")
        precioantes=input("Ingrese el precio de la estacion anterior")

        estacion = Estaciones.Estacion(nombre, siguiente,precio, anteestacion, precioantes)

    def Estacion4(self):
        nombre=input("Ingrese el nombre de la estacion")
        siguiente=input("Ingrese el nombre de la estacion siguiente")
        precio=input("Ingrese el precio de la siguiente estacion")
        anteestacion=input("Ingrese el nombre de la estacion anterior")
        precioantes=input("Ingrese el precio de la estacion anterior")

        estacion = Estaciones.Estacion(nombre, siguiente,precio, anteestacion, precioantes)

    def Estacion5(self):
        nombre=input("Ingrese el nombre de la estacion")
        siguiente=input("Ingrese el nombre de la estacion siguiente")
        precio=input("Ingrese el precio de la siguiente estacion")
        anteestacion=input("Ingrese el nombre de la estacion anterior")
        precioantes=input("Ingrese el precio de la estacion anterior")

        estacion = Estaciones.Estacion(nombre, siguiente,precio, anteestacion, precioantes)

    def Estacion6(self):
        nombre=input("Ingrese el nombre de la estacion")
        siguiente=input("Ingrese el nombre de la estacion siguiente")
        precio=input("Ingrese el precio de la siguiente estacion")
        anteestacion=input("Ingrese el nombre de la estacion anterior")
        precioantes=input("Ingrese el precio de la estacion anterior")

        estacion = Estaciones.Estacion(nombre, siguiente,precio, anteestacion, precioantes)

    def verificar1(self):
        if Ejes.Estacion1().estacion.getNombre() == "Muni" or Ejes.Estacion2().estacion.getNombre()== "Muni" or Ejes.Estacion3().estacion.getNombre()== "Muni" or Ejes.Estacion4().estacion.getNombre()== "Muni" or Ejes.Estacion5().estacion.getNombre()== "Muni" or Ejes.Estacion6().estacion.getNombre()== "Muni" or Ejes.Estacion2().estacion.getNombre() != Ejes.Estacion3().estacion.getNombre() != Ejes.Estacion4().estacion.getNombre() != Ejes.Estacion5().estacion.getNombre() != Ejes.Estacion6().estacion.getNombre() or Ejes.Estacion3().estacion.getNombre() != Ejes.Estacion4().estacion.getNombre() != Ejes.Estacion5().estacion.getNombre() != Ejes.Estacion6().estacion.getNombre() or  Ejes.Estacion4().estacion.getNombre() != Ejes.Estacion5().estacion.getNombre() != Ejes.Estacion6().estacion.getNombre() or Ejes.Estacion5().estacion.getNombre() != Ejes.Estacion6().estacion.getNombre():
            print()
