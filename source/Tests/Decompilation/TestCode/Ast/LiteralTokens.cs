class C {
    int i = 1;
    char c = 'c';

    string s1 = "a\r\nb";
    string s2 = @"a
b";

    object o = null;
}

/* ast

[
  {
    "type": "node",
    "kind": "CompilationUnit",
    "range": "0-126",
    "children": [
      {
        "type": "node",
        "kind": "ClassDeclaration",
        "range": "0-126",
        "children": [
          {
            "type": "token",
            "kind": "ClassKeyword",
            "property": "Keyword",
            "range": "0-6",
            "children": [
              {
                "type": "value",
                "value": "class",
                "range": "0-5"
              },
              {
                "type": "trivia",
                "kind": "WhitespaceTrivia",
                "range": "5-6",
                "value": " "
              }
            ]
          },
          {
            "type": "token",
            "kind": "IdentifierToken",
            "property": "Identifier",
            "range": "6-8",
            "children": [
              {
                "type": "value",
                "value": "C",
                "range": "6-7"
              },
              {
                "type": "trivia",
                "kind": "WhitespaceTrivia",
                "range": "7-8",
                "value": " "
              }
            ]
          },
          {
            "type": "token",
            "kind": "OpenBraceToken",
            "property": "OpenBraceToken",
            "range": "8-11",
            "children": [
              {
                "type": "value",
                "value": "{",
                "range": "8-9"
              },
              {
                "type": "trivia",
                "kind": "EndOfLineTrivia",
                "range": "9-11",
                "value": "\r\n"
              }
            ]
          },
          {
            "type": "node",
            "kind": "FieldDeclaration",
            "range": "11-27",
            "children": [
              {
                "type": "node",
                "kind": "VariableDeclaration",
                "property": "Declaration",
                "range": "11-24",
                "children": [
                  {
                    "type": "node",
                    "kind": "PredefinedType",
                    "property": "Type",
                    "range": "11-19",
                    "children": [
                      {
                        "type": "token",
                        "kind": "IntKeyword",
                        "property": "Keyword",
                        "range": "11-19",
                        "children": [
                          {
                            "type": "trivia",
                            "kind": "WhitespaceTrivia",
                            "range": "11-15",
                            "value": "    "
                          },
                          {
                            "type": "value",
                            "value": "int",
                            "range": "15-18"
                          },
                          {
                            "type": "trivia",
                            "kind": "WhitespaceTrivia",
                            "range": "18-19",
                            "value": " "
                          }
                        ]
                      }
                    ]
                  },
                  {
                    "type": "node",
                    "kind": "VariableDeclarator",
                    "range": "19-24",
                    "children": [
                      {
                        "type": "token",
                        "kind": "IdentifierToken",
                        "property": "Identifier",
                        "range": "19-21",
                        "children": [
                          {
                            "type": "value",
                            "value": "i",
                            "range": "19-20"
                          },
                          {
                            "type": "trivia",
                            "kind": "WhitespaceTrivia",
                            "range": "20-21",
                            "value": " "
                          }
                        ]
                      },
                      {
                        "type": "node",
                        "kind": "EqualsValueClause",
                        "property": "Initializer",
                        "range": "21-24",
                        "children": [
                          {
                            "type": "operation",
                            "property": "Operation",
                            "kind": "FieldInitializer",
                            "properties": {
                              "InitializedFields": "<skipped>",
                              "Locals": "<skipped>"
                            }
                          },
                          {
                            "type": "token",
                            "kind": "EqualsToken",
                            "property": "EqualsToken",
                            "range": "21-23",
                            "children": [
                              {
                                "type": "value",
                                "value": "=",
                                "range": "21-22"
                              },
                              {
                                "type": "trivia",
                                "kind": "WhitespaceTrivia",
                                "range": "22-23",
                                "value": " "
                              }
                            ]
                          },
                          {
                            "type": "node",
                            "kind": "NumericLiteralExpression",
                            "property": "Value",
                            "range": "23-24",
                            "children": [
                              {
                                "type": "operation",
                                "property": "Operation",
                                "kind": "Literal",
                                "properties": {
                                  "ConstantValue": "1",
                                  "Type": "int"
                                }
                              },
                              {
                                "type": "token",
                                "kind": "NumericLiteralToken",
                                "property": "Token",
                                "range": "23-24",
                                "value": "1"
                              }
                            ]
                          }
                        ]
                      }
                    ]
                  }
                ]
              },
              {
                "type": "token",
                "kind": "SemicolonToken",
                "property": "SemicolonToken",
                "range": "24-27",
                "children": [
                  {
                    "type": "value",
                    "value": ";",
                    "range": "24-25"
                  },
                  {
                    "type": "trivia",
                    "kind": "EndOfLineTrivia",
                    "range": "25-27",
                    "value": "\r\n"
                  }
                ]
              }
            ]
          },
          {
            "type": "node",
            "kind": "FieldDeclaration",
            "range": "27-46",
            "children": [
              {
                "type": "node",
                "kind": "VariableDeclaration",
                "property": "Declaration",
                "range": "27-43",
                "children": [
                  {
                    "type": "node",
                    "kind": "PredefinedType",
                    "property": "Type",
                    "range": "27-36",
                    "children": [
                      {
                        "type": "token",
                        "kind": "CharKeyword",
                        "property": "Keyword",
                        "range": "27-36",
                        "children": [
                          {
                            "type": "trivia",
                            "kind": "WhitespaceTrivia",
                            "range": "27-31",
                            "value": "    "
                          },
                          {
                            "type": "value",
                            "value": "char",
                            "range": "31-35"
                          },
                          {
                            "type": "trivia",
                            "kind": "WhitespaceTrivia",
                            "range": "35-36",
                            "value": " "
                          }
                        ]
                      }
                    ]
                  },
                  {
                    "type": "node",
                    "kind": "VariableDeclarator",
                    "range": "36-43",
                    "children": [
                      {
                        "type": "token",
                        "kind": "IdentifierToken",
                        "property": "Identifier",
                        "range": "36-38",
                        "children": [
                          {
                            "type": "value",
                            "value": "c",
                            "range": "36-37"
                          },
                          {
                            "type": "trivia",
                            "kind": "WhitespaceTrivia",
                            "range": "37-38",
                            "value": " "
                          }
                        ]
                      },
                      {
                        "type": "node",
                        "kind": "EqualsValueClause",
                        "property": "Initializer",
                        "range": "38-43",
                        "children": [
                          {
                            "type": "operation",
                            "property": "Operation",
                            "kind": "FieldInitializer",
                            "properties": {
                              "InitializedFields": "<skipped>",
                              "Locals": "<skipped>"
                            }
                          },
                          {
                            "type": "token",
                            "kind": "EqualsToken",
                            "property": "EqualsToken",
                            "range": "38-40",
                            "children": [
                              {
                                "type": "value",
                                "value": "=",
                                "range": "38-39"
                              },
                              {
                                "type": "trivia",
                                "kind": "WhitespaceTrivia",
                                "range": "39-40",
                                "value": " "
                              }
                            ]
                          },
                          {
                            "type": "node",
                            "kind": "CharacterLiteralExpression",
                            "property": "Value",
                            "range": "40-43",
                            "children": [
                              {
                                "type": "operation",
                                "property": "Operation",
                                "kind": "Literal",
                                "properties": {
                                  "ConstantValue": "c",
                                  "Type": "char"
                                }
                              },
                              {
                                "type": "token",
                                "kind": "CharacterLiteralToken",
                                "property": "Token",
                                "range": "40-43",
                                "value": "'c'"
                              }
                            ]
                          }
                        ]
                      }
                    ]
                  }
                ]
              },
              {
                "type": "token",
                "kind": "SemicolonToken",
                "property": "SemicolonToken",
                "range": "43-46",
                "children": [
                  {
                    "type": "value",
                    "value": ";",
                    "range": "43-44"
                  },
                  {
                    "type": "trivia",
                    "kind": "EndOfLineTrivia",
                    "range": "44-46",
                    "value": "\r\n"
                  }
                ]
              }
            ]
          },
          {
            "type": "node",
            "kind": "FieldDeclaration",
            "range": "46-75",
            "children": [
              {
                "type": "node",
                "kind": "VariableDeclaration",
                "property": "Declaration",
                "range": "46-72",
                "children": [
                  {
                    "type": "node",
                    "kind": "PredefinedType",
                    "property": "Type",
                    "range": "46-59",
                    "children": [
                      {
                        "type": "token",
                        "kind": "StringKeyword",
                        "property": "Keyword",
                        "range": "46-59",
                        "children": [
                          {
                            "type": "trivia",
                            "kind": "EndOfLineTrivia",
                            "range": "46-48",
                            "value": "\r\n"
                          },
                          {
                            "type": "trivia",
                            "kind": "WhitespaceTrivia",
                            "range": "48-52",
                            "value": "    "
                          },
                          {
                            "type": "value",
                            "value": "string",
                            "range": "52-58"
                          },
                          {
                            "type": "trivia",
                            "kind": "WhitespaceTrivia",
                            "range": "58-59",
                            "value": " "
                          }
                        ]
                      }
                    ]
                  },
                  {
                    "type": "node",
                    "kind": "VariableDeclarator",
                    "range": "59-72",
                    "children": [
                      {
                        "type": "token",
                        "kind": "IdentifierToken",
                        "property": "Identifier",
                        "range": "59-62",
                        "children": [
                          {
                            "type": "value",
                            "value": "s1",
                            "range": "59-61"
                          },
                          {
                            "type": "trivia",
                            "kind": "WhitespaceTrivia",
                            "range": "61-62",
                            "value": " "
                          }
                        ]
                      },
                      {
                        "type": "node",
                        "kind": "EqualsValueClause",
                        "property": "Initializer",
                        "range": "62-72",
                        "children": [
                          {
                            "type": "operation",
                            "property": "Operation",
                            "kind": "FieldInitializer",
                            "properties": {
                              "InitializedFields": "<skipped>",
                              "Locals": "<skipped>"
                            }
                          },
                          {
                            "type": "token",
                            "kind": "EqualsToken",
                            "property": "EqualsToken",
                            "range": "62-64",
                            "children": [
                              {
                                "type": "value",
                                "value": "=",
                                "range": "62-63"
                              },
                              {
                                "type": "trivia",
                                "kind": "WhitespaceTrivia",
                                "range": "63-64",
                                "value": " "
                              }
                            ]
                          },
                          {
                            "type": "node",
                            "kind": "StringLiteralExpression",
                            "property": "Value",
                            "range": "64-72",
                            "children": [
                              {
                                "type": "operation",
                                "property": "Operation",
                                "kind": "Literal",
                                "properties": {
                                  "ConstantValue": "a\r\nb",
                                  "Type": "string"
                                }
                              },
                              {
                                "type": "token",
                                "kind": "StringLiteralToken",
                                "property": "Token",
                                "range": "64-72",
                                "value": "\"a\\r\\nb\""
                              }
                            ]
                          }
                        ]
                      }
                    ]
                  }
                ]
              },
              {
                "type": "token",
                "kind": "SemicolonToken",
                "property": "SemicolonToken",
                "range": "72-75",
                "children": [
                  {
                    "type": "value",
                    "value": ";",
                    "range": "72-73"
                  },
                  {
                    "type": "trivia",
                    "kind": "EndOfLineTrivia",
                    "range": "73-75",
                    "value": "\r\n"
                  }
                ]
              }
            ]
          },
          {
            "type": "node",
            "kind": "FieldDeclaration",
            "range": "75-101",
            "children": [
              {
                "type": "node",
                "kind": "VariableDeclaration",
                "property": "Declaration",
                "range": "75-98",
                "children": [
                  {
                    "type": "node",
                    "kind": "PredefinedType",
                    "property": "Type",
                    "range": "75-86",
                    "children": [
                      {
                        "type": "token",
                        "kind": "StringKeyword",
                        "property": "Keyword",
                        "range": "75-86",
                        "children": [
                          {
                            "type": "trivia",
                            "kind": "WhitespaceTrivia",
                            "range": "75-79",
                            "value": "    "
                          },
                          {
                            "type": "value",
                            "value": "string",
                            "range": "79-85"
                          },
                          {
                            "type": "trivia",
                            "kind": "WhitespaceTrivia",
                            "range": "85-86",
                            "value": " "
                          }
                        ]
                      }
                    ]
                  },
                  {
                    "type": "node",
                    "kind": "VariableDeclarator",
                    "range": "86-98",
                    "children": [
                      {
                        "type": "token",
                        "kind": "IdentifierToken",
                        "property": "Identifier",
                        "range": "86-89",
                        "children": [
                          {
                            "type": "value",
                            "value": "s2",
                            "range": "86-88"
                          },
                          {
                            "type": "trivia",
                            "kind": "WhitespaceTrivia",
                            "range": "88-89",
                            "value": " "
                          }
                        ]
                      },
                      {
                        "type": "node",
                        "kind": "EqualsValueClause",
                        "property": "Initializer",
                        "range": "89-98",
                        "children": [
                          {
                            "type": "operation",
                            "property": "Operation",
                            "kind": "FieldInitializer",
                            "properties": {
                              "InitializedFields": "<skipped>",
                              "Locals": "<skipped>"
                            }
                          },
                          {
                            "type": "token",
                            "kind": "EqualsToken",
                            "property": "EqualsToken",
                            "range": "89-91",
                            "children": [
                              {
                                "type": "value",
                                "value": "=",
                                "range": "89-90"
                              },
                              {
                                "type": "trivia",
                                "kind": "WhitespaceTrivia",
                                "range": "90-91",
                                "value": " "
                              }
                            ]
                          },
                          {
                            "type": "node",
                            "kind": "StringLiteralExpression",
                            "property": "Value",
                            "range": "91-98",
                            "children": [
                              {
                                "type": "operation",
                                "property": "Operation",
                                "kind": "Literal",
                                "properties": {
                                  "ConstantValue": "a\r\nb",
                                  "Type": "string"
                                }
                              },
                              {
                                "type": "token",
                                "kind": "StringLiteralToken",
                                "property": "Token",
                                "range": "91-98",
                                "value": "@\"a\r\nb\""
                              }
                            ]
                          }
                        ]
                      }
                    ]
                  }
                ]
              },
              {
                "type": "token",
                "kind": "SemicolonToken",
                "property": "SemicolonToken",
                "range": "98-101",
                "children": [
                  {
                    "type": "value",
                    "value": ";",
                    "range": "98-99"
                  },
                  {
                    "type": "trivia",
                    "kind": "EndOfLineTrivia",
                    "range": "99-101",
                    "value": "\r\n"
                  }
                ]
              }
            ]
          },
          {
            "type": "node",
            "kind": "FieldDeclaration",
            "range": "101-125",
            "children": [
              {
                "type": "node",
                "kind": "VariableDeclaration",
                "property": "Declaration",
                "range": "101-122",
                "children": [
                  {
                    "type": "node",
                    "kind": "PredefinedType",
                    "property": "Type",
                    "range": "101-114",
                    "children": [
                      {
                        "type": "token",
                        "kind": "ObjectKeyword",
                        "property": "Keyword",
                        "range": "101-114",
                        "children": [
                          {
                            "type": "trivia",
                            "kind": "EndOfLineTrivia",
                            "range": "101-103",
                            "value": "\r\n"
                          },
                          {
                            "type": "trivia",
                            "kind": "WhitespaceTrivia",
                            "range": "103-107",
                            "value": "    "
                          },
                          {
                            "type": "value",
                            "value": "object",
                            "range": "107-113"
                          },
                          {
                            "type": "trivia",
                            "kind": "WhitespaceTrivia",
                            "range": "113-114",
                            "value": " "
                          }
                        ]
                      }
                    ]
                  },
                  {
                    "type": "node",
                    "kind": "VariableDeclarator",
                    "range": "114-122",
                    "children": [
                      {
                        "type": "token",
                        "kind": "IdentifierToken",
                        "property": "Identifier",
                        "range": "114-116",
                        "children": [
                          {
                            "type": "value",
                            "value": "o",
                            "range": "114-115"
                          },
                          {
                            "type": "trivia",
                            "kind": "WhitespaceTrivia",
                            "range": "115-116",
                            "value": " "
                          }
                        ]
                      },
                      {
                        "type": "node",
                        "kind": "EqualsValueClause",
                        "property": "Initializer",
                        "range": "116-122",
                        "children": [
                          {
                            "type": "operation",
                            "property": "Operation",
                            "kind": "FieldInitializer",
                            "properties": {
                              "InitializedFields": "<skipped>",
                              "Locals": "<skipped>"
                            }
                          },
                          {
                            "type": "token",
                            "kind": "EqualsToken",
                            "property": "EqualsToken",
                            "range": "116-118",
                            "children": [
                              {
                                "type": "value",
                                "value": "=",
                                "range": "116-117"
                              },
                              {
                                "type": "trivia",
                                "kind": "WhitespaceTrivia",
                                "range": "117-118",
                                "value": " "
                              }
                            ]
                          },
                          {
                            "type": "node",
                            "kind": "NullLiteralExpression",
                            "property": "Value",
                            "range": "118-122",
                            "children": [
                              {
                                "type": "operation",
                                "property": "Operation",
                                "kind": "Literal",
                                "properties": {
                                  "ConstantValue": null
                                }
                              },
                              {
                                "type": "token",
                                "kind": "NullKeyword",
                                "property": "Token",
                                "range": "118-122",
                                "value": "null"
                              }
                            ]
                          }
                        ]
                      }
                    ]
                  }
                ]
              },
              {
                "type": "token",
                "kind": "SemicolonToken",
                "property": "SemicolonToken",
                "range": "122-125",
                "children": [
                  {
                    "type": "value",
                    "value": ";",
                    "range": "122-123"
                  },
                  {
                    "type": "trivia",
                    "kind": "EndOfLineTrivia",
                    "range": "123-125",
                    "value": "\r\n"
                  }
                ]
              }
            ]
          },
          {
            "type": "token",
            "kind": "CloseBraceToken",
            "property": "CloseBraceToken",
            "range": "125-126",
            "value": "}"
          }
        ]
      },
      {
        "type": "token",
        "kind": "EndOfFileToken",
        "property": "EndOfFileToken",
        "range": "126-126",
        "value": ""
      }
    ]
  }
]

*/