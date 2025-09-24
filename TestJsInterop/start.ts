import { Example, TestType } from "./TestJsInterop.mjs";

// Call a method exported by the .NET module.
let result = Example.hello(".NET");

const testType = new TestType();
console.log();

result = Example.importTestType(testType);

console.log("Result from example: ", result);
