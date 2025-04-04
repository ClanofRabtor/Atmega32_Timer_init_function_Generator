# Timer Initialization Code Generator for ATmega32

This project provides a C# utility to automatically generate C code for initializing the Timer/Counter modules (Timer0, Timer1, and Timer2) on the ATmega32 microcontroller. This tool simplifies the process of configuring timers for various applications such as generating PWM signals, creating precise delays, and implementing event counting.

## Overview

The core of this project is the `C_func` static class with its `Generate` method. This method takes parameters specifying the desired timer configuration (timer selection, prescaler, operating mode, output compare values, and compare output modes) and returns a string containing the corresponding C code that can be directly included in your ATmega32 project.

## Features

* **Supports Timer0, Timer1, and Timer2:** Generates initialization code for all three 8-bit and 16-bit timers available on the ATmega32.
* **Configurable Prescaler:** Allows you to select the clock prescaler value to control the timer's counting speed.
* **Mode Selection:** Supports various timer operating modes, including:
    * **Timer0 & Timer2:** Normal Mode, PWM Phase Correct, CTC Mode, Fast PWM.
    * **Timer1:** Normal Mode, PWM Phase Correct (8, 9, 10-bit), CTC Mode (OCR1A as TOP, ICR1 as TOP), Fast PWM (8, 9, 10-bit, OCR1A as TOP, ICR1 as TOP), Phase and Frequency Correct PWM (ICR1 as TOP, OCR1A as TOP), Phase Correct PWM (ICR1 as TOP, OCR1A as TOP).
* **Output Compare Unit (Channels A & B):** Enables configuration of the Output Compare Registers (OCRxA, OCRxB) for setting compare values in CTC and PWM modes.
* **Compare Output Mode (Channels A & B):** Allows you to define the behavior of the output compare pins (OCx) on a compare match, such as toggling, clearing, or setting the pin.
* **Clear and Readable C Code:** The generated C code is well-formatted and includes comments to explain the configuration.

## Usage

1.  **Include the C# Code:** Add the `C_func.cs` file (or the entire `Timer_initBuilder` project) to your C# development environment.
2.  **Call the `Generate` Method:** In your C# code, call the `C_func.Generate()` method, providing the desired timer configuration parameters.

    ```csharp
    string timerCode = C_func.Generate(
        timer: "Timer1",
        prescaler: 64,
        mode: 4, // CTC Mode (OCR1A as TOP)
        ocrValueA: 15624,
        comModeA: 2 // Clear OC1A on compare match
    );

    Console.WriteLine(timerCode);
    ```

3.  **Copy and Paste the Generated C Code:** The `Generate` method will return a string containing the C initialization function (e.g., `INIT_Timer1()`). Copy this function and paste it into your ATmega32 C project (e.g., in your `main.c` or a dedicated timer initialization file).
4.  **Call the Initialization Function:** In your ATmega32 C code, call the generated initialization function (e.g., `INIT_Timer1();`) within your main program initialization section.

## Parameters for the `Generate` Method

| Parameter   | Type    | Description                                                                                                                                                               
| :---------- | :------ | :----------------------------------------------------------------------------------------------------------------------------------------                                 
| `timer`     | `string`| Specifies the timer to initialize: `"Timer0"`, `"Timer1"`, or `"Timer2"`.                                                                                                 
| `prescaler` | `int`   | The prescaler value for the timer's clock source (e.g., 1, 8, 64, 256, 1024 for Timer0/1; 1, 8, 32, 64, 128, 256, 1024 for Timer2).                                       
| `mode`      | `int`   | The operating mode of the timer. Refer to the ATmega32 datasheet for the specific mode numbers available for each timer.                                                  
| `ocrValueA` | `int?`  | (Optional) The value to be loaded into Output Compare Register A (OCRxA). Use `null` or `0` if not needed.                                                                
| `comModeA`  | `int?`  | (Optional) The Compare Output Mode for channel A. Refer to the ATmega32 datasheet for the specific COM mode numbers. Use `null` or `0` if not needed.                     
| `ocrValueB` | `int?`  | (Optional) The value to be loaded into Output Compare Register B (OCRxB) (only for Timer1). Use `null` or `0` if not needed.                                              
| `comModeB`  | `int?`  | (Optional) The Compare Output Mode for channel B (only for Timer1). Refer to the ATmega32 datasheet for the specific COM mode numbers. Use `null` or `0` if not needed.   

## Important Notes

* **ATmega32 Datasheet:** Always refer to the ATmega32 microcontroller datasheet for a comprehensive understanding of the timer/counter modules, their operating modes, prescaler options, and compare output modes. The mode numbers used in this generator correspond to the definitions in the datasheet.
* **Pin Configuration:** The generated code for Compare Output Modes includes setting the corresponding data direction register (DDRx) bit to make the OCx pin an output. Ensure that this aligns with your hardware setup.
* **Error Handling:** The C# code includes basic `default` cases in the `switch` statements for prescaler to remind the user to select a valid value. You might want to add more robust error handling in your C# application.
* **Further Configuration:** This generator focuses on the fundamental timer initialization. You might need to add further configurations in your C code, such as enabling interrupts related to the timers.

## Contributing

Contributions to this project are welcome. Feel free to fork the repository, make improvements, and submit pull requests.