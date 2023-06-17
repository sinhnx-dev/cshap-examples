ShapeFactory shapeFactory = new ShapeFactory();

//get an object of Circle and call its draw method.
Shape? shape1 = shapeFactory.GetShape("CIRCLE");
//call draw method of Circle
if (shape1 != null) shape1.Draw();

//get an object of Rectangle and call its draw method.
Shape? shape2 = shapeFactory.GetShape("RECTANGLE");
//call draw method of Rectangle
if (shape2 != null) shape2.Draw();

//get an object of Square and call its draw method.
Shape? shape3 = shapeFactory.GetShape("SQUARE");
//call draw method of Square
if (shape3 != null) shape3.Draw();