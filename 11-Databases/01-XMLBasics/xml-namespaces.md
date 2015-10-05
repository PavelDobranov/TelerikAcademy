### What do namespaces represent in an XML document? What are they used for?

XML namespaces are used for providing uniquely named elements and attributes in an XML document. They are defined in a W3C recommendation. An XML instance may contain element or attribute names from more than one XML vocabulary. If each vocabulary is given a namespace, the ambiguity between identically named elements or attributes can be resolved.

A simple example would be to consider an XML instance that contained references to a customer and an ordered product. Both the customer element and the product element could have a child element named id. References to the id element would therefore be ambiguous; placing them in different namespaces would remove the ambiguity.

An XML namespace is declared using the reserved XML attribute xmlns or xmlns:prefix, the value of which must be a valid namespace name.

For example, the following declaration maps the "xhtml:" prefix to the XHTML namespace:

```
xmlns:xhtml="http://www.w3.org/1999/xhtml"
```

Any element or attribute whose name starts with the prefix "xhtml:" is considered to be in the XHTML namespace, if it or an ancestor has the above namespace declaration.

It is also possible to declare a default namespace. For example:

```
xmlns="http://www.w3.org/1999/xhtml"
```