__author__ = 'Lester'
#inicia la clase
class  circulo(object):

    #Constructor
    def __init__(self, radio):
        self.radio = radio

    Const_Pi=3.14

    def perimetro (self):
        return 2*circulo.Const_Pi*self.radio


    def tarea (self):
        return circulo.Const_Pi*(self.radio**2)

        #Fin Clase

r = input()






