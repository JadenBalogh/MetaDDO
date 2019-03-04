## The Goal

Take a collection of Items, each with a list of Effects, and automatically construct the strongest gearset possible given the options.

## The Method

First, lets try just testing every combination of items and taking the top "N" gearsets.

### Input

The user inputs a weight for each Stat. This should be represented by an easy-to-read list of Stats with corresponding input fields.

### Global Variables

ITEMS; Imported list of Items
STAT_NAMES; ArrayList of Strings compiled from ITEMS
STAT_WEIGHTS; ArrayList of ints assigned by the user

### Gearsets

Each Gearset has:
 - items; Array (size: 11)
 - stats; Array (size: statNames.length)

### Items

Each Item has:
 - name
 - effects; ArrayList of Effects

### Stats

Each Stat has:
 - name; from STAT_NAMES
 - total; sum of amounts
 - amounts; a HashTable (key: StackingType, value: amount)
 - weight; assigned by user

### Effects

Each Effect has:
 - name; from STAT_NAMES
 - amount
 - stackingType
 
 #### StackingType
 
 An Enum of stacking types used as a key to map an Effect's stackingType to an amount.
