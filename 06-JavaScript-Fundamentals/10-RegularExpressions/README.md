# Regular Expressions

### Problem 1. Format with placeholders
* Write a function that formats a string. The function should have placeholders, as shown in the example
  * Add the function to the `String.prototype`

_Example 1:_

**input**

```javascript
var options = {name: 'John'};
'Hello, there! Are you #{name}?'.format(options);
```

**output**

```javascript
'Hello, there! Are you John'
```

_Example 2:_

**input**

```javascript
var options = {name: 'John', age: 13};
'My name is #{name} and I am #{age}-years-old'.format(options);
```

**output**

```javascript
'My name is John and I am 13-years-old'
```

### Problem 2. HTML binding
* Write a function that puts the value of an object into the content/attributes of HTML tags.
  * Add the function to the `String.prototype`

_Example 1:_

**input**

```javascript
var str = '<div data-bind-content="name"></div>';
str.bind(str, {name: 'Steven'});
```

**output**

```html
<div data-bind-content="name">Steven</div>
```

_Example 2:_

**input**

```javascript
var bindingString = '<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></a>'
str.bind(str, {name: 'Elena', link: 'http://telerikacademy.com'});
```

**output**

```html
<a data-bind-content="name" data-bind-href="link" data-bind-class="name" href="http://telerikacademy.com" class="Elena">Elena</a>
```