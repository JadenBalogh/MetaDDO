## The Goal

Take a collection of Items, each with a list of Effects, and automatically construct the strongest gearset possible given the options.

## The Method

First, lets try just testing every combination of items and taking the top "N" gearsets.

### Input

The user inputs a weight for each Stat. This should be represented by an easy-to-read list of Stats with corresponding input fields.

### Global Variables
 - ITEMS; Imported list of Items
 - STAT_NAMES; ArrayList of Strings compiled from ITEMS
 - STAT_WEIGHTS; ArrayList of ints assigned by the user

### Gearset
 - items; Array (size: 11)
 - stats; Array (size: statNames.length)

### Item
 - name
 - effects; ArrayList of Effects

### Stat
 - name; from STAT_NAMES
 - total; sum of amounts
 - amounts; a HashTable (key: StackingType, value: amount)
 - weight; assigned by user

### Effect
 - name; from STAT_NAMES
 - amount
 - stackingType
 
### StackingType
 - Enum of stacking effect types
