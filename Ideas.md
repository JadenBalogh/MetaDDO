## The Goal

Take a collection of Items, each with a list of Effects, and automatically construct the strongest gearset possible given the options.

## The Method

First, lets try just testing every combination of items and taking the top 5 gearsets.

### Weighting System

Each Effect needs to be assigned a weight before optimization to allow the user to select exactly what type of gearset they want.

### Gearsets

A list of Items and a list of Stats. Each effect will have 

### Items

Each Item has:
 - name
 - effects; ArrayList of Effects

### Stats

Each Stat has:
 - name
 - total; sum of amounts
 - amounts; a HashTable (key: StackingType, value: amount)
 - weight; assigned by user

### Effects

Each Effect has:
 - name
 - amount
 - stackingType
 
 #### StackingType
 
 An Enum of stacking types used as a key to map an Effect's stackingType to an amount.
