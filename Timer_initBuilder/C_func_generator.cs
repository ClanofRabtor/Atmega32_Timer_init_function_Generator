using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer_initBuilder
{
    public static class C_func
    {
        public static string Generate(string timer, int prescaler, int mode, int? ocrValueA = null, int? comModeA = null, int? ocrValueB = null, int? comModeB = null)
        {
            StringBuilder cCode = new StringBuilder();

            if (timer == "Timer0")
            {
                // Handle Timer0 initialization
                cCode.AppendLine("void INIT_Timer0(void) {");
                cCode.AppendLine("    TCCR0 = 0; // Reset TCCR0");
                cCode.AppendLine("    TCNT0 = 0; // Reset Timer Counter");

                // Add Mode Selection for Timer0
                switch (mode)
                {
                    case 0: // Normal Mode
                        cCode.AppendLine("    TCCR0 |= 0x00;");
                        break;
                    case 1: // PWM, Phase Correct
                        cCode.AppendLine("    TCCR0 |= (1 << WGM00);");
                        break;
                    case 2: // CTC Mode
                        cCode.AppendLine("    TCCR0 |= (1 << WGM01);");
                        break;
                    case 3: // Fast PWM
                        cCode.AppendLine("    TCCR0 |= (1 << WGM00) | (1 << WGM01);");
                        break;
                }

                // Prescaler Selection for Timer0
                switch (prescaler)
                {
                    case 1:
                        cCode.AppendLine("    TCCR0 |= (1 << CS00);");
                        break;
                    case 8:
                        cCode.AppendLine("    TCCR0 |= (1 << CS01);");
                        break;
                    case 64:
                        cCode.AppendLine("    TCCR0 |= (1 << CS00) | (1 << CS01);");
                        break;
                    case 256:
                        cCode.AppendLine("    TCCR0 |= (1 << CS02);");
                        break;
                    case 1024:
                        cCode.AppendLine("    TCCR0 |= (1 << CS00) | (1 << CS02);");
                        break;
                    default:
                        cCode.AppendLine("    // Use the right prescaler!");
                        break;
                }

                if (ocrValueA != 0)
                {
                    // Add OCR Value if provided
                    cCode.AppendLine($"    OCR0 = {ocrValueA.Value};");
                }

                if (comModeA != 0)
                {
                    // Add COM Mode for OC0 if provided
                    switch (comModeA)
                    {
                        case 1: // Toggle OC0 on compare match
                            cCode.AppendLine("    TCCR0 |= (1 << COM00);");
                            break;
                        case 2: // Clear OC0 on compare match
                            cCode.AppendLine("    TCCR0 |= (1 << COM01);");
                            break;
                        case 3: // Set OC0 on compare match
                            cCode.AppendLine("    TCCR0 |= (1 << COM00) | (1 << COM01);");
                            break;
                    }
                    cCode.AppendLine("    DDRB |= (1 << PB3);");  // Set the direction of OC0 (Pin 3 on Port B)
                }

                cCode.AppendLine("}");
            }

            if (timer == "Timer1")
            {
                // Handle Timer1 initialization
                cCode.AppendLine("void INIT_Timer1(void) {");
                cCode.AppendLine("    TCCR1A = 0; // Reset TCCR1A");
                cCode.AppendLine("    TCCR1B = 0; // Reset TCCR1B");
                cCode.AppendLine("    TCNT1 = 0; // Reset Timer Counter");

                // Mode Selection for Timer1
                switch (mode)
                {
                    case 0: // Normal Mode
                        cCode.AppendLine("    TCCR1B |= 0x00;");
                        break;
                    case 1: // PWM, Phase Correct 8-bit
                        cCode.AppendLine("    TCCR1A |= (1 << WGM10);");
                        break;
                    case 2: // PWM, Phase Correct 9-bit
                        cCode.AppendLine("    TCCR1A |= (1 << WGM11);");
                        break;
                    case 3: // PWM, Phase Correct 10-bit
                        cCode.AppendLine("    TCCR1A |= (1 << WGM11) | (1 << WGM10);");
                        break;
                    case 4: // CTC Mode (OCR1A as TOP)
                        cCode.AppendLine("    TCCR1B |= (1 << WGM12);");
                        break;
                    case 5: // Fast PWM 8-bit
                        cCode.AppendLine("    TCCR1A |= (1 << WGM10);");
                        cCode.AppendLine("    TCCR1B |= (1 << WGM12);");
                        break;
                    case 6: // Fast PWM 9-bit
                        cCode.AppendLine("    TCCR1A |= (1 << WGM11);");
                        cCode.AppendLine("    TCCR1B |= (1 << WGM12);");
                        break;
                    case 7: // Fast PWM 10-bit
                        cCode.AppendLine("    TCCR1A |= (1 << WGM11) | (1 << WGM10);");
                        cCode.AppendLine("    TCCR1B |= (1 << WGM12);");
                        break;
                    case 8: // Phase and Frequency Correct PWM (ICR1 as TOP)
                        cCode.AppendLine("    TCCR1B |= (1 << WGM13);");
                        break;
                    case 9: // Phase and Frequency Correct PWM (OCR1A as TOP)
                        cCode.AppendLine("    TCCR1A |= (1 << WGM10);");
                        cCode.AppendLine("    TCCR1B |= (1 << WGM13);");
                        break;
                    case 10: // Phase Correct PWM (ICR1 as TOP)
                        cCode.AppendLine("    TCCR1A |= (1 << WGM11);");
                        cCode.AppendLine("    TCCR1B |= (1 << WGM13);");
                        break;
                    case 11: // Phase Correct PWM (OCR1A as TOP)
                        cCode.AppendLine("    TCCR1A |= (1 << WGM11) | (1 << WGM10);");
                        cCode.AppendLine("    TCCR1B |= (1 << WGM13);");
                        break;
                    case 12: // CTC Mode (ICR1 as TOP)
                        cCode.AppendLine("    TCCR1B |= (1 << WGM12) | (1 << WGM13);");
                        break;
                    case 14: // Fast PWM (ICR1 as TOP)
                        cCode.AppendLine("    TCCR1A |= (1 << WGM11);");
                        cCode.AppendLine("    TCCR1B |= (1 << WGM12) | (1 << WGM13);");
                        break;
                    case 15: // Fast PWM (OCR1A as TOP)
                        cCode.AppendLine("    TCCR1A |= (1 << WGM11) | (1 << WGM10);");
                        cCode.AppendLine("    TCCR1B |= (1 << WGM12) | (1 << WGM13);");
                        break;
                }

                // Prescaler Selection for Timer1
                switch (prescaler)
                {
                    case 1:
                        cCode.AppendLine("    TCCR1B |= (1 << CS10);");
                        break;
                    case 8:
                        cCode.AppendLine("    TCCR1B |= (1 << CS11);");
                        break;
                    case 64:
                        cCode.AppendLine("    TCCR1B |= (1 << CS10) | (1 << CS11);");
                        break;
                    case 256:
                        cCode.AppendLine("    TCCR1B |= (1 << CS12);");
                        break;
                    case 1024:
                        cCode.AppendLine("    TCCR1B |= (1 << CS10) | (1 << CS12);");
                        break;
                    default:
                        cCode.AppendLine("    // Use the right prescaler!");
                        break;
                }

                // Handle OCR1A (OC1A) and OCR1B (OC1B)
                if (ocrValueA != 0)
                {
                    cCode.AppendLine($"    OCR1A = {ocrValueA.Value};");
                }

                if (ocrValueB != 0)
                {
                    cCode.AppendLine($"    OCR1B = {ocrValueB.Value};");
                }

                // COM Modes for OC1A (Pin 9) and OC1B (Pin 10)
                if (comModeA != 0)
                {
                    switch (comModeA)
                    {
                        case 1:
                            cCode.AppendLine("    TCCR1A |= (1 << COM1A0);");
                            break;
                        case 2:
                            cCode.AppendLine("    TCCR1A |= (1 << COM1A1);");
                            break;
                        case 3:
                            cCode.AppendLine("    TCCR1A |= (1 << COM1A0) | (1 << COM1A1);");
                            break;
                    }
                    cCode.AppendLine("    DDRB |= (1 << PD5);");  // Set the direction of OC1A (Pin 9 on Port B)
                }

                if (comModeB != 0)
                {
                    switch (comModeB)
                    {
                        case 1:
                            cCode.AppendLine("    TCCR1A |= (1 << COM1B0);");
                            break;
                        case 2:
                            cCode.AppendLine("    TCCR1A |= (1 << COM1B1);");
                            break;
                        case 3:
                            cCode.AppendLine("    TCCR1A |= (1 << COM1B0) | (1 << COM1B1);");
                            break;
                    }
                    cCode.AppendLine("    DDRB |= (1 << PD4);");  // Set the direction of OC1B (Pin 10 on Port B)
                }

                cCode.AppendLine("}");
            }

            if (timer == "Timer2")
            {
                // Handle Timer2 initialization
                cCode.AppendLine("void INIT_Timer2(void) {");
                cCode.AppendLine("    TCCR2 = 0; // Reset TCCR2");
                cCode.AppendLine("    TCNT2 = 0; // Reset Timer Counter");

                // Mode Selection for Timer2
                switch (mode)
                {
                    case 0: // Normal Mode
                        cCode.AppendLine("    TCCR2 |= 0x00;");
                        break;
                    case 1: // PWM, Phase Correct
                        cCode.AppendLine("    TCCR2 |= (1 << WGM20);");
                        break;
                    case 2: // CTC Mode
                        cCode.AppendLine("    TCCR2 |= (1 << WGM21);");
                        break;
                    case 3: // Fast PWM
                        cCode.AppendLine("    TCCR2 |= (1 << WGM20) | (1 << WGM21);");
                        break;
                }

                // Prescaler Selection for Timer2
                switch (prescaler)
                {
                    case 1:
                        cCode.AppendLine("    TCCR2 |= (1 << CS20);");
                        break;
                    case 8:
                        cCode.AppendLine("    TCCR2 |= (1 << CS21);");
                        break;
                    case 32:
                        cCode.AppendLine("    TCCR2 |= (1 << CS20) | (1 << CS21);");
                        break;
                    case 64:
                        cCode.AppendLine("    TCCR2 |= (1 << CS22);");
                        break;
                    case 128:
                        cCode.AppendLine("    TCCR2 |= (1 << CS20) | (1 << CS22);");
                        break;
                    case 256:
                        cCode.AppendLine("    TCCR2 |= (1 << CS21) | (1 << CS22);");
                        break;
                    case 1024:
                        cCode.AppendLine("    TCCR2 |= (1 << CS20) | (1 << CS21) | (1 << CS22);");
                        break;
                    default:
                        cCode.AppendLine("    // Use the right prescaler!");
                        break;
                }

                if (ocrValueA != 0)
                {
                    cCode.AppendLine($"    OCR2 = {ocrValueA.Value};");
                }

                if (comModeA != 0)
                {
                    switch (comModeA)
                    {
                        case 1:
                            cCode.AppendLine("    TCCR2 |= (1 << COM20);");
                            break;
                        case 2:
                            cCode.AppendLine("    TCCR2 |= (1 << COM21);");
                            break;
                        case 3:
                            cCode.AppendLine("    TCCR2 |= (1 << COM20) | (1 << COM21);");
                            break;
                    }
                    cCode.AppendLine("    DDRD |= (1 << PD7);");  // Set the direction of OC2 (Pin 7 on Port D)
                }

                cCode.AppendLine("}");
            }

            return cCode.ToString();
        }
    }
}