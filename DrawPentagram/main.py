#Pentagram Challenge - www.101computing.net/pentagram-challenge/
import turtle, math
myPen = turtle.Turtle()
myPen.shape("arrow")
myPen.pencolor("red")
myPen.pensize(2)
myPen.speed(1000)

#A Procedure to draw a polygon from a list of vertices.
def drawPolygon(polygon):
 myPen.penup()
 myPen.goto(polygon[0][0],polygon[0][1])
 myPen.pendown()
 
 for i in range(1,len(polygon)):
    myPen.goto(polygon[i][0],polygon[i][1])
 
 myPen.goto(polygon[0][0],polygon[0][1])
 
 
#A polygon can be stored as a list of vertices 
pentagon=[]
R = 150
for n in range(0,5):
  x = R*math.cos(math.radians(90+n*71.5))
  y = R*math.sin(math.radians(90+n*71.5))
  pentagon.append([x,y])

pentagram=[]
r = 150
for n in range(0,5):
  x = r*math.cos(math.radians(195-n*142.5))
  y = r*math.sin(math.radians(195-n*142.5))
  pentagram.append([x,y])

#drawPolygon(pentagon)
drawPolygon(pentagram)
myPen.hideturtle()