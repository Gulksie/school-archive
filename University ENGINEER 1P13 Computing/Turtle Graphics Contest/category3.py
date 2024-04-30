# Michael Gulka, gulkam
# submission for ENG1P13 Turtle Graphics Contest, category 3
# The purpose of this program is to use the turtle libarary to tile Koch Snowflakes
# This shape was chosen because I am not very artistically inclined
# All calculations (aside from area, which was not used) were done by myself and require no citation

import turtle
import math
from PIL import Image
import io

# init the window
window = turtle.Screen()
width, height = 800, 800
window.setup(width, height)
window.bgcolor("white")
window.title("Koch Snowflake")

# init turtle drawer
pen = turtle.Turtle()
pen.shape("turtle")
pen.speed(0)
pen.radians()


# flake class, this represents a Koch snowflake (basically a list of all lines in the flake)
class Flake:
    def __init__(self, startX, startY, startLength):

            line0 = Line(startX, startY, startLength, 0)
            
            x1 = startX + startLength
            y1 = startY
            line1 = Line(x1, y1, startLength, 2*math.pi/3)

            x2 = x1 + startLength * math.cos(2*math.pi/3)
            y2 = y1 + startLength * math.sin(2*math.pi/3)
            line2 = Line(x2, y2, startLength, 4*math.pi/3)

            self.lines = [line0, line1, line2]

    def foldLines(self):
        foldedList = [None] * len(self.lines) * 4

        for i in range(len(self.lines)):
            foldedList[i*4], foldedList[i*4+1], foldedList[i*4+2], foldedList[i*4+3] = self.lines[i].fold()
        
        self.lines = foldedList

    def drawLines(self, pen):
        #tracer = turtle.tracer()
        #delay = turtle.delay()

        #turtle.tracer(0, 0)
        for i in self.lines:
            i.draw(pen)
        
        #turtle.update()
        #turtle.tracer(tracer, delay)

    def getPerimeter(self):
        permimeter = 0
        for i in self.lines:
            permimeter += i.magnitude

        return permimeter

    @staticmethod
    def drawFromPos(x, y, initalLength, pen):
        '''Draws a flake, starting at the inital x, y'''

        shape = Flake(x, y, initalLength)

        while initalLength > 1:
            shape.foldLines()
            initalLength /= 3
        
        shape.drawLines(pen)

    @staticmethod
    def getSideLength(x1, x2, y1, y2):
        '''
        Returns the max side length of a flake within the bounding box defined by (x1, y1) and (x2, y2)
        
        Note: Turtle saves a few pixels to use for itself! Don't pass the dimensions of a window
        '''

        x = x2-x1
        y = y2-y1

        if y >= x:  # bound by x
            return x

        # bound by y
        # calculate the max sidelength we can have with given y
        # s = 3y/2sqrt3

        s = 3*y/(2*math.sqrt(3))

        return s

    @staticmethod
    def getStartPosition(x1, x2, y1, y2, sideLength=None):
        '''Gets a start position from the box defined by (x1, y1), (x2, y2)'''
        if sideLength is None:
            sideLength = Flake.getSideLength(x1, x2, y1, y2)

        # we want to centre the Flake within the bounding box
        avgx = (x1+x2)/2
        avgy = (y1+y2)/2

        x = avgx - sideLength/2
        y = avgy - sideLength*math.sqrt(3)/4 + sideLength*math.sqrt(3)/12

        return x, y

    @staticmethod
    def drawInBox(x1, x2, y1, y2, pen):
        '''
        Draws a Flake in the box defined by (x1, y1), (x2, y2)
        
        Note: Turtle saves a few pixels to use for itself! Don't pass the dimensions of a window
        '''

        sideLength = Flake.getSideLength(x1, x2, y1, y2)
        startPos = Flake.getStartPosition(x1, x2, y1, y2, sideLength) 

        Flake.drawFromPos(startPos[0], startPos[1], sideLength, pen)


# line class, this is a vector representation of each line in the shape
class Line:
    def __init__(self, startx, starty, magnitude, direction):
        self.startx = startx
        self.starty = starty
        self.magnitude = magnitude
        self.direction = direction

    def fold(self):
        '''returns the fold of this line - i.e. 4 seperate lines which are the result of going 1 iteration into the fractal'''

        mag = self.magnitude/3

        # define each line
        line0 = Line(self.startx, self.starty, mag, self.direction)
        
        # we need to calculate the new position of each vector by adding it onto the previous vector
        x1 = self.startx + mag * math.cos(self.direction)
        y1 = self.starty + mag * math.sin(self.direction)
        dir1 = self.direction - (math.pi/3)

        line1 = Line(x1, y1, mag, dir1)

        x2 = x1 + mag * math.cos(dir1)
        y2 = y1 + mag * math.sin(dir1)
        dir2 = dir1 + (2*math.pi/3)

        line2 = Line(x2, y2, mag, dir2)

        x3 = self.startx + 2*mag * math.cos(self.direction)
        y3 = self.starty + 2*mag * math.sin(self.direction)
        
        line3 = Line(x3, y3, mag, self.direction)

        return line0, line1, line2, line3
    
    def draw(self, pen):
        pen.penup()
        pen.setx(self.startx)
        pen.sety(self.starty)
        pen.setheading(self.direction)
        pen.pendown()
        pen.forward(self.magnitude)

# we will draw each side recursivley
# THIS RECURSIVE METHOD DOESN'T WORK!
# A possible recursive approach could be to draw the triangle, then on each recursion erase a third of each flat line and replace it with a triangle

# def drawSide(length):
#     if length <= 1:
#         pen.forward(length)
#         return
    
#     pen.forward(length/3)

#     pen.right(math.pi/3)
#     drawSide(length/3)
#     #pen.forward(length/9)
#     pen.left(2*math.pi/3)
#     drawSide(length/3)
#     #pen.forward(length/9)
#     pen.right(math.pi/3)
    
#     pen.forward(length/3)
    

# for i in range(3):
#     drawSide(sideLength)
#     pen.left(2*math.pi/3)

#Flake.drawInBox(-(width-20)/2, (width-20)/2, -(height-20)/2, (height-20)/2, pen)

iterations = 8
widthPer = (width-30)/iterations
heightPer = (height-30)/iterations
print(widthPer)
print(heightPer)

turtle.tracer(0,0)
for i in range(iterations):
    y1 = heightPer * (i-iterations/2)
    y2 = heightPer * (i+1-iterations/2)
    for j in range(iterations):
        x1 = widthPer * (j-iterations/2)
        x2 = widthPer * (j+1-iterations/2)

        Flake.drawInBox(x1, x2, y1, y2, pen)
        turtle.update()
        
pen.hideturtle()
ps = turtle.getscreen().getcanvas().postscript(file="out.ps")
turtle.exitonclick()
