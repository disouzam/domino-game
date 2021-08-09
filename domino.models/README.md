This class library contains an own implementation of a domino games, from the models that represent the pieces to classes that encapsulate the rules of one or more games.

A domino game is made of a set of tiles.
> Each domino is a retangular tile with a line dividing its face into two square ends. Each end is marked with a number of spots (also called pips or dots) or is blank [...] The traditional European domino set consists of 28 tiles, also known as pieces, bones, rocks, stones, men, cards or just dominoes, featuring all combinations of spot counts between zero and six. (Source: https://en.wikipedia.org/wiki/Dominoes)

So far, I am trying to implement the ideas I have while playing to the definitions of what each class / interface should have, trying as much as possible to build on abstractions and using tests to encapsulate the rules of my thinking process.

A brief description of this thought process through the classes and interfaces created follows:

1. Although there is a tentative to abstract the size of domino sets, most resources deal with a domino set with a maximum number of pips of 6;
1. So the domino set under consideration has 28 tiles;
1. A domino set is like an immutable entity; the tiles are drawn from it to make stocks or to make the tiles that each player has;
1. The stock is variable in size, from 0 tiles to the maximum number of tiles of a given domino set;
1. There is already a method that mimics a part of shuffle tiles;
1. It is still pending a tracking of tiles (in which state a tile is in a given moment to have a clear view anytime during a game - maybe that control should be delegated to a game class);
1. A player should implement IDominoActor but it is possible that my initial idea was wrong and I would need to use inheritance to avoid duplication of code (or default interface methods - https://channel9.msdn.com/Shows/On-NET/C-Language-Highlights-Default-Interface-Methods)