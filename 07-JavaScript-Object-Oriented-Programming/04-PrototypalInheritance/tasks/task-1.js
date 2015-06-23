// Task Description
// Create an object domElement, that has the following properties and methods:
//   1) use prototypal inheritance, without function constructors
//   2) method init() that gets the domElement type
//     * i.e. `Object.create(domElement).init('div')`
//   3) property type that is the type of the domElement
//     * a valid type is any non-empty string that contains only Latin letters and digits
//   4) property innerHTML of type string
//     * gets the domElement, parsed as valid HTML
//     * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>
//   5) property content of type string
//     * sets the content of the element
//     * works only if there are no children
//   6) property attributes
//     * each attribute has name and value
//     * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
//   7) property children
//    * each child is a domElement or a string
//   8) property parent
//    * parent is a domElement
//   9) method appendChild(domElement / string)
//    * appends to the end of children list
//   10) method addAttribute(name, value)
//    * throw Error if type is not valid
//   11) method removeAttribute(attribute)

// Example:

// var meta = Object.create(domElement)
//   .init('meta')
//   .addAttribute('charset', 'utf-8');

// var head = Object.create(domElement)
//   .init('head')
//   .appendChild(meta)

// var div = Object.create(domElement)
//   .init('div')
//   .addAttribute('style', 'font-size: 42px');

// div.content = 'Hello, world!';

// var body = Object.create(domElement)
//   .init('body')
//   .appendChild(div)
//   .addAttribute('id', 'cuki')
//   .addAttribute('bgcolor', '#012345');

// var root = Object.create(domElement)
//   .init('html')
//   .appendChild(head)
//   .appendChild(body);

// console.log(root.innerHTML);

// Outputs:

// <html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="cuki"><div style="font-size: 42px">Hello, world!</div></body></html>

function solve() {
  var domElement = (function() {
    var domElement = {
      init: function(type) {
        this.type = trype;
        return this;
      },





      appendChild: function(child) {
        this.appendChild(child);
        return this;
      },
      addAttribute: function(name, value) {
        this.setAttribute(name, value);
      },
      get type() {
				return this._type;
      },
			set type(value) {
				// TODO: Validation
				this._type = value;
			},

      get innerHTML() {
        return this.innerHTML;
      }
    };

    return domElement;
  }());

  return domElement;
}

module.exports = solve;
