class   Estudiante(object):
    """Representa a un estudiante"""

    def __init__(self, nombre, nota1, nota2, nota3):
        """Constructor de la Clase Estudiante"""
        self._nombre = nombre
        self._nota1 = nota1
        self._nota2 = nota2
        self._nota3 = nota3

        def getNombre(self):
            """Retorna el nombre del estudiante"""
            return self._nombre

        def getNota1(self):
            """Retorna nota1"""
            return self._nota1

        def getNota2(self):
            """Retorna nota2"""
            return self._nota2

        def getNota3(self):
            """Retorna nota3"""
            return self._nota3

        def getPromedio(self):
            """Retorna el promedio de la notas"""
            return round(((self._nota1, self._nota2, self._nota3)/3),2)

        def getNotaMaxima(self):
            """Retorna la nota más alta"""
            return max(self._nota1, self._nota2, self._nota3)

        def __str__(self):
            """Retorna al estudiante representado por un String"""
            return "Nombre: " + self._nombre + "\nNotas: " + str(self._nota1) + "," + str(self._nota2) + "," + str(self._nota3)



