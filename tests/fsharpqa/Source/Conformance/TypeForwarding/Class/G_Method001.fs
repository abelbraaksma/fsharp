//This tests the basic functionality of the type forwarder on generic class
//forwarded type doesn't contain the method

let gc = new Method_NotInForwarder<int>()
let rv = gc.getValue()

exit rv
