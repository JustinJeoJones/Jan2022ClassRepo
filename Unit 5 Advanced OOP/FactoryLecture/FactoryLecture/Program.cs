using FactoryLecture;

ShapeFactory factory = new ShapeFactory();

IShape shape = factory.getShape("triangle");
shape.Draw();