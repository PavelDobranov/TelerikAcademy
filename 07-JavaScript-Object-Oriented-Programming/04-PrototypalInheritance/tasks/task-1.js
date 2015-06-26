// Task Description:
// Create an object domElement, that has the following properties and methods:
//  1. Use prototypal inheritance, without function constructors
//  2. Method init() that gets the domElement type
//    * i.e. Object.create(domElement).init('div');
//  3. Property type that is the type of the domElement
//    * a valid type is any non-empty string that contains only Latin letters and digits
//  4. Property innerHTML of type string
//    * gets the domElement, parsed as valid HTML:
//      <type attr1="value1" attr2="value2" ... > ... content / children's.innerHTML</type>
//    * attributes must be sorted in ascending alphabetical order by their name, not in the order they were added
//  5. Property content of type string
//    * sets the content of the element
//    * works only if there are no children
//  6. Property attributes
//    * each attribute has name and value
//    * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes -
//  7. Property children
//    * each child is a domElement or a string
//  8. Property parent
//    * parent is a domElement
//  9. Method appendChild(domElement / string)
//    * appends to the end of children list
//  10. Method addAttribute(name, value)
//    * throw Error if type is not valid
//  11. Method removeAttribute(attribute)

function solve() {
  'use strict';

  var domElement = (function() {
    var domElement = {
      init: function(type) {
        this.type = type;
        this.content = '';
        this.attributes = {};
        this.children = [];
        this.parent = null;

        return this;
      },
      get type() {
        return this._type;
      },
      set type(value) {
        if (!isValidType(value)) {
          throw new Error('Type must be a non-empty string, contains only latin letters and digits!');
        }

        this._type = value;
      },
      get content() {
        if (this.children.length) {
          return '';
        }

        return this._content;
      },
      set content(value) {
        this._content = value;
      },
      get attributes() {
        return this._attributes;
      },
      set attributes(value) {
        this._attributes = value;
      },
      get children() {
        return this._children;
      },
      set children(value) {
        this._children = value;
      },
      get parent() {
        return this._parent;
      },
      set parent(value) {
        this._parent = value;
      },
      get innerHTML() {
        var attributes = stringifyAttributes(this.attributes),
          result = '<' + this.type + attributes + '>';

        result += this.children.reduce(function(result, child) {
          if (typeof child === 'string') {
            return result += child;
          } else {
            return result += child.innerHTML;
          }
        }, '');

        result += this.content + '</' + this.type + '>';

        return result;
      },
      appendChild: function(child) {
        if (typeof child === 'object') {
          child.parent = this;
        }

        this.children.push(child);

        return this;
      },
      addAttribute: function(name, value) {
        if (!isValidAttributeName(name)) {
          throw new Error('Attribute name must be anon-empty string, contains only latin letters and digits or dashes (-)!');
        }

        this.attributes[name] = value;

        return this;
      },
      removeAttribute: function(name) {
        if (!this.attributes[name]) {
          throw new Error('Attribute "' + name + '" does not exist!');
        }

        delete this._attributes[name];

        return this;
      }
    };

    function isValidType(type) {
      return typeof type === 'string' && /^[A-Za-z0-9]+$/.test(type);
    }

    function isValidAttributeName(name) {
      return typeof name === 'string' && /^[A-Za-z0-9\-]+$/.test(name);
    }

    function stringifyAttributes(attributes) {
      var result = Object.keys(attributes)
        .sort()
        .reduce(function(res, item) {
          return res += ' ' + item + '="' + attributes[item] + '"';
        }, '');

      return result;
    }

    return domElement;
  }());

  return domElement;
}

module.exports = solve;
