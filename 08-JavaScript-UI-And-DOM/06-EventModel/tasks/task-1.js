/*
Create a function that takes an id or DOM element and:
* If an id is provided, select the element
* Finds all elements with class 'button' or 'content' within the provided element
  * Change the content of all '.button' elements with "hide"
* When a '.button' is clicked:
  * Find the topmost '.content' element, that is before another '.button' and:
    * If the '.content' is visible:
      * Hide the '.content'
      * Change the content of the '.button' to "show"
    * If the '.content' is hidden:
      * Show the '.content'
      * Change the content of the '.button' to "hide"
    * If there isn't a '.content' element **after the clicked '.button'** and **before other '.button'**, do nothing
* Throws if:
  * The provided DOM element is non-existant
  * The id is either not a string or does not select any DOM element
*/

function solve() {
  function isString(item) {
    return typeof item === 'string';
  }

  function isValidHtmlElement(element) {
    return element instanceof HTMLElement;
  }

  function handleElementClick(event) {
    var clickedElement = event.target;

    if (clickedElement.classList.contains('button')) {
      handleButtonClick(clickedElement);
    }
  }

  function handleButtonClick(button) {
    var nextElementSibling = button.nextElementSibling,
      currentElement,
      currentElementIsContent,
      nextElementIsButton,
      content;

    while (nextElementSibling) {
      currentElement = nextElementSibling;
      nextElementSibling = currentElement.nextElementSibling;

      if (!nextElementSibling) {
        break;
      }

      currentElementIsContent = currentElement.classList.contains('content');
      nextElementIsButton = nextElementSibling.classList.contains('button');

      if (currentElementIsContent && nextElementIsButton) {
        content = currentElement;
        break;
      }
    }

    if (content) {
      button.innerHTML = button.innerHTML === 'hide' ? 'show' : 'hide';
      content.style.display = content.style.display === 'none' ? '' : 'none';
    }
  }

  return function (selector) {
    var domElement,
      buttons,
      button;

    if (!selector) {
      throw new Error();
    }

    if (!isString(selector) && !isValidHtmlElement(selector)) {
      throw new Error();
    }

    if (isString(selector)) {
      domElement = document.getElementById(selector);

      if (!domElement) {
        throw new Error('There is no element that has an id: ' + selector);
      }
    } else {
      domElement = selector;
    }

    buttons = domElement.getElementsByClassName('button');

    for (button = 0; button < buttons.length; button++) {
      buttons[button].innerHTML = 'hide';
    }

    domElement.addEventListener('click', handleElementClick, false);
  };
}

module.exports = solve;