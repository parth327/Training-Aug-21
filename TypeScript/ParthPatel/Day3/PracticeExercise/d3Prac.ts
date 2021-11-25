// Generics
//Generic Type Variables
function loggingIdentity<Type>(arg: Array<Type>): Array<Type> {
    console.log(arg.length);
    return arg;
  }
//Generic Types
interface GenericIdentityFn<Type> {
    (arg: Type): Type;
  }
  function identity<Type>(arg: Type): Type {
    return arg;
  }
  let myIdentity: GenericIdentityFn<number> = identity;
//Generic Classes
class GenericNumber<NumType> {
    zeroValue: NumType;
    add: (x: NumType, y: NumType) => NumType;
  }
   
  let myGenericNumber = new GenericNumber<number>();
  myGenericNumber.zeroValue = 0;
  myGenericNumber.add = function (x, y) {
    return x + y;
  };
//Generic Constraints
interface Lengthwise {
    length: number;
  }
   function loggingIdentity1<Type extends Lengthwise>(arg: Type): Type {
    console.log(arg.length);
    return arg;
  }
loggingIdentity1({ length: 10, value: 3 });

// Namespaces
//Namespaced Validators
namespace Validation {
    export interface StringValidator {
      isAcceptable(s: string): boolean;
    }
    const lettersRegexp = /^[A-Za-z]+$/;
    const numberRegexp = /^[0-9]+$/;
    export class LettersOnlyValidator implements StringValidator {
      isAcceptable(s: string) {
        return lettersRegexp.test(s);
      }
    }
    export class ZipCodeValidator implements StringValidator {
      isAcceptable(s: string) {
        return s.length === 5 && numberRegexp.test(s);
      }
    }
  }
  let strings = ["Hello","7667","100"];
//Aliases
namespace Shapes {
    export namespace Polygons {
      export class Triangle {}
      export class Square {}
    }
  }
  import polygons = Shapes.Polygons;
  let sq = new polygons.Square();

//Modules
//Export
//Re-Export
export class ParseIntBasedZipCodeValidator {
    isAcceptable(s: string) {
      return s.length === 5 && parseInt(s).toString() === s;
    }
  }// Export original validator but rename it
  export { ZipCodeValidator as RegExpBasedZipCodeValidator } from "./ZipCodeValidator";

// Import
//Importing Types
// Re-using the same import
import { APIResponseType } from "./api";
// Explicitly use import type
import type { APIResponseType } from "./api";

// Code Generation for Modules
export interface StringValidator {
    isAcceptable(s: string): boolean;
  }
  import { StringValidator } from "./Validation";
const lettersRegexp = /^[A-Za-z]+$/;
export class LettersOnlyValidator implements StringValidator {
  isAcceptable(s: string) {
    return lettersRegexp.test(s);
  }
}
import { StringValidator } from "./Validation";
const numberRegexp = /^[0-9]+$/;
export class ZipCodeValidator implements StringValidator {
  isAcceptable(s: string) {
    return s.length === 5 && numberRegexp.test(s);
  }
}
import { StringValidator } from "./Validation";
import { ZipCodeValidator } from "./ZipCodeValidator";
import { LettersOnlyValidator } from "./LettersOnlyValidator";
// Some samples to try
let strings = ["Hello", "98052", "101"];
// Validators to use
let validators: { [s: string]: StringValidator } = {};
validators["ZIP code"] = new ZipCodeValidator();
validators["Letters only"] = new LettersOnlyValidator();
// Show whether each string passed each validator
strings.forEach((s) => {
  for (let name in validators) {
    console.log(
      `"${s}" - ${
        validators[name].isAcceptable(s) ? "matches" : "does not match"
      } ${name}`
    );
  }
});
