// illegal construct
// Compile Time Error: The constructor SingleObject() is not visible
// SingleObject object = new SingleObject();

//Get the only object available
SingleObject obj = SingleObject.GetInstance();

//show the message
obj.ShowMessage("Singleton Pattern Demo...");