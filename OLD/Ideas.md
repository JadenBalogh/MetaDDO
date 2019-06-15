## The Goal

Take a collection of Items, each with a list of Effects, and automatically construct the strongest gearset possible given the options.

## The Method

First, lets try just testing every combination of Items and taking the top few Gearsets. The power of a Gearset is determined by the sum of each Stat's (current value / max value) times the weight for that Stat.

#### Input

The user inputs a weight for each Stat. This should be represented by an easy-to-read list of Stats with corresponding input fields.

#### Global Variables
 - ITEMS; Imported list of Items
 - STAT_NAMES; ArrayList of Strings compiled from ITEMS
 - STAT_WEIGHTS; ArrayList of ints assigned by the user
 
 - topGearsets; Array (size: number of top Gearsets desired)

#### Gearset
 - items; Array (size: 11)
 - stats; Array (size: statNames.length)

#### Item
 - name
 - effects; ArrayList of Effects

#### Stat
 - name; from STAT_NAMES
 - relativeAmount; total / max
 - total; sum of amounts
 - max; calculated max possible amount given the list of available ITEMS
 - amounts; a HashTable (key: StackingType, value: amount)
 - weight; assigned by user

#### Effect
 - name; from STAT_NAMES
 - amount
 - stackingType
 
#### StackingType
 - Enum of stacking effect types
