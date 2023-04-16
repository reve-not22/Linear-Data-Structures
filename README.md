# Linear Data Structures

1. A linked list is typically used when having a large number of items or when you need to remove items from a list. You would use it, most likely, to save performance (as you wouldn't have to shift all list values when removing an item, only redirect pointers). 
2. A stack is a linear data structure that adheres to "last in, first out" while a queue uses "first in, first out". In other words, a stack only lets you view/take the most recent entry while a queue lets you take the very first entry rather than the most recent.
3. As an example, a developer might use a stack for a state machine. Once an AI finishes with a certain task, it removes it from the stack and starts looking at the next entry. When the AI sees a player or something of importance, it could check priority and then add it to the top of the stack (once finished with the current task, it would return to whatever it was doing earlier).
4. A developer might use an array over a list when he/she does not need to change its size. For example, a system of coordinates. Additionally, arrays are faster at accessing specific elements than lists.
