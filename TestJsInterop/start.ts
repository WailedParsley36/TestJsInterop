import { Example, TestType } from "./TestJsInterop.mjs";

// Call a method exported by the .NET module.
const result = Example.hello(".NET");

Example.importTestType(new TestType());

console.log("Result from example: ", result);
