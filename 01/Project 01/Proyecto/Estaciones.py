__author__ = 'Lester'
#se importa la libreria
import csv
class Estacion(object):
    def __init__(self, nombre, nextestacion, nextprecio, preestacion, precioants):
        self.nombre=nombre
        self.nextestacion=nextestacion
        self.nextprecio=nextprecio
        self.preestacion=preestacion
        self.precioants=precioants

    def abrirEstacion(self):
        v=True
        #Se verifica que la estacion No existe anteriormente
        estacion=csv.reader(open('Estaciones/Estaciones.csv',"r"));
        for row in estacion:
            if(row[0]!=self.nombre):
                v=True
            else:
                v=False
        if(v==True):
            save = open('Estaciones/Estaciones.csv', "a")
            save.write(self.nombre+','+self.nextestacion+','+self.nextprecio+','+self.preestacion+','+self.precioants+'\n');
        else:
            print("ERROR");

    def getNombre(self):
        return self.nombre;
        return self.nextestacion;
        return self.nextprecio;
        return self.preestacion;
        return self.precioants;







