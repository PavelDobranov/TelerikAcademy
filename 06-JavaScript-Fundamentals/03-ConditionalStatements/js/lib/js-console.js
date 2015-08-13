var javaScriptConsole = (function() {
  'use strict';

  var JsConsole = (function() {
    function JsConsole(selector) {
      this.domElement = document.querySelector(selector);
      this.textArea = document.createElement('p');
      this.domElement.appendChild(this.textArea);
    }

    JsConsole.prototype.write = function(input) {
      var text = input,
        textLine = document.createElement('span');

      textLine.innerHTML = text;
      this.textArea.appendChild(textLine);
    };

    JsConsole.prototype.writeLine = function(text) {
      this.write(text);

      this.textArea.appendChild(document.createElement('br'));
    };

    JsConsole.prototype.readText = function(selector) {
      var element;

      if (selector instanceof HTMLElement) {
        element = selector;
      } else {
        element = document.querySelector(selector);
      }

      return element.value;
    };

    JsConsole.prototype.readInteger = function(selector) {
      var element;

      if (selector instanceof HTMLElement) {
        element = selector;
      } else {
        element = document.querySelector(selector);
      }

      if (!isValidInteger(element.value)) {
        throw new TypeError('Please enter valid integer value : [ ' + element.name + ' ]');
      }

      return parseInt(element.value, 10);
    };

    JsConsole.prototype.readFloat = function(selector) {
      var element;

      if (selector instanceof HTMLElement) {
        element = selector;
      } else {
        element = document.querySelector(selector);
      }

      if (!isValidFloat(element.value)) {
        throw new TypeError('Please enter valid float value : [ ' + element.name + ' ]');
      }

      return parseFloat(element.value);
    };

    JsConsole.prototype.readArray = function(selector) {
      var element;

      if (selector instanceof HTMLElement) {
        element = selector;
      } else {
        element = document.querySelector(selector);
      }

      try {
        return JSON.parse('[' + element.value + ']');
      } catch (e) {
        throw new Error('Invalid input : [ ' + element.name + ' ]');
      }
    };

    JsConsole.prototype.clear = function(selector) {
      this.textArea.innerHTML = '';
    };

    return JsConsole;
  }());

  function isValidInteger(input) {
    return isValidFloat(input) && Number(input) % 1 === 0;
  }

  function isValidFloat(input) {
    return input === "0" || Boolean(+input);
  }

  function createInstance(selector) {
    return new JsConsole(selector);
  }

  return {
    createInstance: createInstance
  };
}());