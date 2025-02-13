# Narayana's Cows Sequence

This repository explores Narayana's cows sequence, a fascinating mathematical sequence attributed to the Indian mathematician Narayana Pandita. The sequence exhibits exponential growth characteristics, making it an intriguing subject for analysis and experimentation.

## About Narayana's Cows Sequence
The sequence is defined by the recurrence relation:

N(n)=N(n−1)+N(n−3)

Where the initial terms are:

N(0) = 0, N(1) = 1, N(2) = 1


For more information, refer to the following resources:
- [Wikipedia on Narayana Pandita and his sequence](https://en.wikipedia.org/wiki/Narayana_Pandita_(mathematician)#Narayana's_cows_sequence) ![Wikipedia Icon](https://img.icons8.com/color/48/000000/wikipedia.png)
- [Journal of Integer Sequences](https://cs.uwaterloo.ca/journals/JIS/VOL23/Das/bravo17.pdf) ![Journal Icon](https://img.icons8.com/ios-filled/50/000000/journal.png)

## Repository Overview
This repository contains:

1. **Implementations**:
   - Various algorithms to generate and analyze Narayana's cows sequence.
   - Representation of sequence values in different numeral systems, including:
     - Decimal
     - Hexadecimal
     - Binary

   ![Code Icon](https://img.icons8.com/fluency/48/000000/code.png)

2. **Exponential Growth Analysis**:
   - Demonstration of exponential growth behavior in the sequence.
   - Mathematical modeling using the exponential growth equation:
     
     P(t) = P<sub>0</sub> e<sup>rt</sup>
     
     Where:
     - \(P(t)\): Population at time \(t\)
     - \(P_0\): Initial population
     - \(r\): Growth rate
     - \(t\): Time elapsed or iterations (discrete perspective)

   

   Below is an example graph showing the growth of the sequence over iterations:

  

## Challenges
One challenge in working with this sequence is that the decimal representation of values exceeds standard data types (e.g., `long`) at around \(10^{19}\). To address this, the repository includes:
- Alternative representations (hexadecimal, binary) for large numbers.
- Optimized algorithms to handle growth efficiently.

## License
This project is released into the public domain under the [Unlicense](https://unlicense.org). For details, see the [LICENSE](./LICENSE) file.


## Contributions
Contributions and suggestions are welcome! Feel free to open an issue or submit a pull request to improve the code, documentation, or analysis.



---

Happy experimenting with Narayana's cows sequence!
