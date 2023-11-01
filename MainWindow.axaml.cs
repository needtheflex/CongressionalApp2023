using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Data;

namespace lockedIn;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void returnHome(object sender, PointerReleasedEventArgs e)
    {
        archiveStackPanel.IsVisible = false;
        budgetingAndSavingsStackPanel.IsVisible = false;
        financialCalculatorsStackPanel.IsVisible = false;
        homeStackPanel.IsVisible = true;
    }

    private void archiveClicked(object sender, RoutedEventArgs e)
    {
        homeStackPanel.IsVisible = false;
        archiveStackPanel.IsVisible = true;
    }

    private void financialCalculatorClicked(object sender, RoutedEventArgs e)
    {
        homeStackPanel.IsVisible = false;
        financialCalculatorsStackPanel.IsVisible = true;
    }
    private void budgetClicked(object sender, RoutedEventArgs e)
    {
        homeStackPanel.IsVisible = false;
        budgetingAndSavingsStackPanel.IsVisible = true;
    }


    private void goToBudgetCalculationsStackPanel(object sender, RoutedEventArgs e)
    {
        budgetingAndSavingsStackPanel.IsVisible = false;
        budgetCalculationStackPanel.IsVisible = true;

        if (Double.TryParse(annualIncomeUserInput.Text, out double unused))
        {
            double difference = double.Parse(annualIncomeUserInput.Text) - double.Parse(debtUserInput.Text);
            assets.Text = "assets: $" + difference.ToString();
            income.Text = "income: $" + annualIncomeUserInput.Text;

            newTaxOrMortgage.Text = "$" + ((double.Parse(annualIncomeUserInput.Text) * 0.30).ToString());
            newUtilities.Text = "$" + ((double.Parse(annualIncomeUserInput.Text) * 0.10).ToString());
            newInsurance.Text = "$" + ((double.Parse(annualIncomeUserInput.Text) * 0.15).ToString());
            newTransportation.Text = "$" + ((double.Parse(annualIncomeUserInput.Text) * 0.10).ToString());
            newFoodOrGroceries.Text = "$" + ((double.Parse(annualIncomeUserInput.Text) * 0.15).ToString());
            newOtherSpending.Text = "$" + ((double.Parse(annualIncomeUserInput.Text) * 0.20).ToString());

            if (Double.TryParse(mortgageOrRentUserInput.Text, out double a) &&
                Double.TryParse(utilitiesUserInput.Text, out double b) &&
                Double.TryParse(transportationUserInput.Text, out double c) &&
                Double.TryParse(foodAndGroceriesUserInput.Text, out double d) &&
                Double.TryParse(insurancesUserInput.Text, out double p) &&
                Double.TryParse(otherSpendingUserInput.Text, out double f))
            {
                if (difference < 0 || ((a + b + c + d + p + f <= 101)))
                {
                    recommendation.Text = "start a plan to pay off your liabilities!";
                    return;
                }
                else if (double.Parse(mortgageOrRentUserInput.Text) > 30)
                {
                    recommendation.Text = "try finding cheaper housing!";
                    return;
                }
                else if (double.Parse(utilitiesUserInput.Text) > 10)
                {
                    recommendation.Text = "try to use less electricity!";
                    return;
                }
                else if (double.Parse(foodAndGroceriesUserInput.Text) > 15)
                {
                    recommendation.Text = "try to find alternatives for your brand of food!";
                    return;
                }
                else if (double.Parse(transportationUserInput.Text) > 10)
                {
                    recommendation.Text = "try to find alternatives for your transportation!";
                    return;
                }
                else if (double.Parse(insurancesUserInput.Text) > 15)
                {
                    recommendation.Text = "try to find an alternative to your insurance!";
                    return;
                }
                else if (double.Parse(otherSpendingUserInput.Text) > 20)
                {
                    recommendation.Text = "try to add more to your savings!";
                    return;
                }
                else
                {
                    recommendation.Text = "make sure you have an emergency fund!";
                }
            }
            else
            {
                recommendation.Text = "add your current budget for a recommendation!";
            }
        }
        else
        {
            assets.Text = "$0";
            income.Text = "$0";
            recommendation.Text = "make sure to input values as numbers!";
        }
    }
    private void returnToBudgetStackPanel(object sender, PointerReleasedEventArgs e)
    {
        budgetCalculationStackPanel.IsVisible = false;
        budgetingAndSavingsStackPanel.IsVisible = true;
    }

    private void returnToArchive(object sender, PointerReleasedEventArgs e)
    {
        inflationArchive.IsVisible = false;
        debitvsCreditArchive.IsVisible = false;
        financeInstitutionsArchive.IsVisible = false;
        interestRatesArchive.IsVisible = false;
        taxesArchive.IsVisible = false;
        makingDecisionsArchive.IsVisible = false;
        settingGoalsArchive.IsVisible = false;
        financeAccountsArchive.IsVisible = false;
        incomeArchive.IsVisible = false;
        archiveStackPanel.IsVisible = true;
    }

    private void openInflationArchive(object sender, RoutedEventArgs e)
    {
        archiveStackPanel.IsVisible = false;
        inflationArchive.IsVisible = true;
    }
    private void openDebitVsCreditArchive(object sender, RoutedEventArgs e)
    {
        archiveStackPanel.IsVisible = false;
        debitvsCreditArchive.IsVisible = true;
    }
    private void openFinanceInstitutionsArchive(object sender, RoutedEventArgs e)
    {
        archiveStackPanel.IsVisible = false;
        financeInstitutionsArchive.IsVisible = true;
    }

    private void openInterestRateArchive(object sender, RoutedEventArgs e)
    {
        archiveStackPanel.IsVisible = false;
        interestRatesArchive.IsVisible = true;
    }
    private void openTaxesArchive(object sender, RoutedEventArgs e)
    {
        archiveStackPanel.IsVisible = false;
        taxesArchive.IsVisible = true;
    }

    private void openMakingDecisionsArchive(object sender, RoutedEventArgs e)
    {
        archiveStackPanel.IsVisible = false;
        makingDecisionsArchive.IsVisible = true;
    }

    private void openSettingGoalsArchive(object sender, RoutedEventArgs e)
    {
        archiveStackPanel.IsVisible = false;
        settingGoalsArchive.IsVisible = true;
    }

    private void openingFinanceAccountsArchive(object sender, RoutedEventArgs e)
    {
        archiveStackPanel.IsVisible = false;
        financeAccountsArchive.IsVisible = true;
    }

    private void openingIncomeArchive(object sender, RoutedEventArgs e)
    {
        archiveStackPanel.IsVisible = false;
        incomeArchive.IsVisible = true;
    }

    private void returnToFinancialCalculator(object sender, PointerReleasedEventArgs e)
    {
        inflationCalculator.IsVisible = false;
        deflationCalculator.IsVisible = false;
        appreciationCalculator.IsVisible = false;
        depreciationCalculator.IsVisible = false;
        simpleInterestCalculator.IsVisible = false;
        compoundInterestCalculator.IsVisible = false;
        financialCalculatorsStackPanel.IsVisible = true;
    }

    private void openInflationCalculator(object sender, RoutedEventArgs e)
    {
        financialCalculatorsStackPanel.IsVisible = false;
        inflationCalculator.IsVisible = true;
    }
    private void openDeflationCalculator(object sender, RoutedEventArgs e)
    {
        financialCalculatorsStackPanel.IsVisible = false;
        deflationCalculator.IsVisible = true;
    }
    private void openAppreciationCalculator(object sender, RoutedEventArgs e)
    {
        financialCalculatorsStackPanel.IsVisible = false;
        appreciationCalculator.IsVisible = true;
    }
    private void openDepreciationCalculator(object sender, RoutedEventArgs e)
    {
        financialCalculatorsStackPanel.IsVisible = false;
        depreciationCalculator.IsVisible = true;
    }
    private void openSimpleInterestCalculator(object sender, RoutedEventArgs e)
    {
        financialCalculatorsStackPanel.IsVisible = false;
        simpleInterestCalculator.IsVisible = true;
    }
    private void openCompoundInterestCalculator(object sender, RoutedEventArgs e)
    {
        financialCalculatorsStackPanel.IsVisible = false;
        compoundInterestCalculator.IsVisible = true;
    }

    private void calculateInflation(object sender, RoutedEventArgs e)
    {

        /////// INFLATION NEEDS TIME VARIABLE!!!!!!!!!!! XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX IMPORTANTTTTTTTTTTTTT
        ///// -69420 used for placeholder to avoid errors. What are the odds these are the values, not likely. (especially at our target age)
        double newPrice = -69420;
        double oldPrice = -69420;
        double rate = -69420;
        double time = -69420; ///////place holder until it can be added
        int emptyCount = 0;
        if (Double.TryParse(inflationOldPriceUserInput.Text, out double unused))
        {
            oldPrice = Double.Parse(inflationOldPriceUserInput.Text);
        } else
        {
            emptyCount++;
        }
        if (Double.TryParse(inflationNewPriceUserInput.Text, out double a))
        {
            newPrice = Double.Parse(inflationNewPriceUserInput.Text);
        } else
        {
            emptyCount++;
        }
        if (Double.TryParse(inflationRateUserInput.Text, out double b))
        {
            rate = Double.Parse(inflationRateUserInput.Text);
        } else
        {
            emptyCount++;
        }
        /* PLACE HOLDER FOR TIME VARIABLE
        if (Double.TryParase(inflationTimeUserInput.Text out double c))
        {
            time = Double.Parse(inflationTimeUserInput.Text);
        }
        else 
        {
            emptyCount++;
        }
         */

        if (emptyCount >1)
        {
            inflationValue.Text = "too many missing variables";
            return;
        } else if (emptyCount == 0)
        {
            inflationValue.Text = "no variables to solve for!";
            return;
        }

        if (newPrice == -69420)
        {
            inflationNewPriceUserInput.Text = (oldPrice * Math.Pow(1+rate, time)).ToString();
            return;
        }

        if (oldPrice == -69420)
        {
            inflationOldPriceUserInput.Text = (newPrice / Math.Pow(1 + rate, time)).ToString();
            return;
        }

        if (rate == -69420)
        {
            if (newPrice < oldPrice)
            {
                inflationValue.Text = "this looks like deflation!";
                inflationRateUserInput.Text = " ";
                return;
            }
            if (oldPrice == 0 || newPrice == oldPrice)
            {
                inflationRateUserInput.Text = "0.000";
            }
            inflationRateUserInput.Text = ((oldPrice - newPrice) / oldPrice * 100).ToString();
            return;
        }

        if (time == -69420)
        {
            //placeholder~~~~  inflationTimeUserInput.Text = Math.Log(newPrice/oldPrice, rate).ToString();
            return;
        }
        return;

    }

    private void calculateDeflation(object sender, RoutedEventArgs e)
    {

        /////// INFLATION NEEDS TIME VARIABLE!!!!!!!!!!! XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX IMPORTANTTTTTTTTTTTTT
        ///// -69420 used for placeholder to avoid errors. What are the odds these are the values, not likely. (especially at our target age)
        double newPrice = -69420;
        double oldPrice = -69420;
        double rate = -69420;
        double time = -69420; ///////place holder until it can be added
        int emptyCount = 0;
        if (Double.TryParse(deflationOldPriceUserInput.Text, out double unused))
        {
            oldPrice = Double.Parse(deflationOldPriceUserInput.Text);
        }
        else
        {
            emptyCount++;
        }
        if (Double.TryParse(deflationNewPriceUserInput.Text, out double a))
        {
            newPrice = Double.Parse(deflationNewPriceUserInput.Text);
        }
        else
        {
            emptyCount++;
        }
        if (Double.TryParse(deflateRateUserInput.Text, out double b))
        {
            rate = Double.Parse(deflateRateUserInput.Text);
        }
        else
        {
            emptyCount++;
        }
        /* PLACE HOLDER FOR TIME VARIABLE
        if (Double.TryParase(deflationTimeUserInput.Text out double c))
        {
            time = Double.Parse(deflationTimeUserInput.Text);
        }
        else 
        {
            emptyCount++;
        }
         */

        if (emptyCount > 1)
        {
            inflationValue.Text = "too many missing variables";
            return;
        }
        else if (emptyCount == 0)
        {
            inflationValue.Text = "no variables to solve for!";
            return;
        }

        if (newPrice == -69420)
        {
            deflationNewPriceUserInput.Text = (oldPrice * Math.Pow(1 + rate, time)).ToString();
            return;
        }

        if (oldPrice == -69420)
        {
            deflationOldPriceUserInput.Text = (newPrice / Math.Pow(1 + rate, time)).ToString();
            return;
        }

        if (rate == -69420)
        {
            if (newPrice < oldPrice)
            {
                deflationValue.Text = "this looks like deflation!";
                deflateRateUserInput.Text = " ";
                return;
            }
            if (oldPrice == 0 || newPrice == oldPrice)
            {
                deflateRateUserInput.Text = "0.000";
            }
            deflateRateUserInput.Text = ((oldPrice - newPrice) / oldPrice * 100).ToString();
            return;
        }

        if (time == -69420)
        {
            //placeholder~~~~  deflationTimeUserInput.Text = Math.Log(newPrice/oldPrice, rate).ToString();
            return;
        }
        return;

    }


    private void calculateAppreciation(object sender, RoutedEventArgs e)
    {


        double newPrice = -69420;
        double oldPrice = -69420;
        double rate = -69420;
        double time = -69420; 
        int emptyCount = 0;
        if (Double.TryParse(appreciationOriginalPriceUserInput.Text, out double unused))
        {
            oldPrice = Double.Parse(appreciationOriginalPriceUserInput.Text);
        }
        else
        {
            emptyCount++;
        }
        if (Double.TryParse(appreciationFutureValueUserInput.Text, out double a))
        {
            newPrice = Double.Parse(appreciationFutureValueUserInput.Text);
        }
        else
        {
            emptyCount++;
        }
        if (Double.TryParse(appreciationRateUserInput.Text, out double b))
        {
            rate = Double.Parse(appreciationRateUserInput.Text);
        }
        else
        {
            emptyCount++;
        }
        
        if (Double.TryParse(appreciationYearsIntoFuture.Text, out double c))
        {
            time = Double.Parse(appreciationYearsIntoFuture.Text);
        }
        else 
        {
            emptyCount++;
        }

        if (emptyCount > 1)
        {
            inflationValue.Text = "too many missing variables";
            return;
        }
        else if (emptyCount == 0)
        {
            inflationValue.Text = "no variables to solve for!";
            return;
        }

        if (newPrice == -69420)
        {
            deflationNewPriceUserInput.Text = (oldPrice * Math.Pow(1 + rate, time)).ToString();
            return;
        }

        if (oldPrice == -69420)
        {
            deflationOldPriceUserInput.Text = (newPrice / Math.Pow(1 + rate, time)).ToString();
            return;
        }

        if (rate == -69420)
        {
            if (newPrice < oldPrice)
            {
                appreciationValue.Text = "this looks like depreciation!";
                appreciationRateUserInput.Text = " ";
                return;
            }
            if (oldPrice == 0 || newPrice == oldPrice)
            {
                appreciationRateUserInput.Text = "0.000";
            }
            appreciationRateUserInput.Text = ((oldPrice - newPrice) / oldPrice * 100).ToString();
            return;
        }

        if (time == -69420)
        {
            appreciationYearsIntoFuture.Text = Math.Log(newPrice/oldPrice, rate).ToString();
            return;
        }
        return;

    }

    private void calculateDepreciation(object sender, RoutedEventArgs e)
    {

       
        double newPrice = -69420;
        double oldPrice = -69420;
        double rate = -69420;
        double time = -69420; 
        int emptyCount = 0;
        if (Double.TryParse(depreciationOriginalPriceUserInput.Text, out double unused))
        {
            oldPrice = Double.Parse(depreciationOriginalPriceUserInput.Text);
        }
        else
        {
            emptyCount++;
        }
        if (Double.TryParse(depreciationFutureValueUserInput.Text, out double a))
        {
            newPrice = Double.Parse(depreciationFutureValueUserInput.Text);
        }
        else
        {
            emptyCount++;
        }
        if (Double.TryParse(depreciationRateUserInput.Text, out double b))
        {
            rate = Double.Parse(depreciationRateUserInput.Text);
        }
        else
        {
            emptyCount++;
        }

        if (Double.TryParse(depreciationYearsIntoFuture.Text, out double c))
        {
            time = Double.Parse(depreciationYearsIntoFuture.Text);
        }
        else
        {
            emptyCount++;
        }

        if (emptyCount > 1)
        {
            inflationValue.Text = "too many missing variables";
            return;
        }
        else if (emptyCount == 0)
        {
            inflationValue.Text = "no variables to solve for!";
            return;
        }

        if (newPrice == -69420)
        {
            depreciationFutureValueUserInput.Text = (oldPrice * Math.Pow(1 - rate, time)).ToString();
            return;
        }

        if (oldPrice == -69420)
        {
            depreciationFutureValueUserInput.Text = (newPrice / Math.Pow(1 - rate, time)).ToString();
            return;
        }

        if (rate == -69420)
        {
            if (newPrice > oldPrice)
            {
                depreciationValue.Text = "this looks like appreciation!";
                depreciationRateUserInput.Text = " ";
                return;
            }
            if (oldPrice == 0 || newPrice == oldPrice)
            {
                depreciationRateUserInput.Text = "0.000";
            }
            depreciationRateUserInput.Text = ((oldPrice - newPrice) / oldPrice * 100).ToString();
            return;
        }

        if (time == -69420)
        {
            depreciationYearsIntoFuture.Text = Math.Log(newPrice / oldPrice, rate).ToString();
            return;
        }
        return;

    }

    private void calculateSimpleInterest(object sender, RoutedEventArgs e)
    {
        if (Double.TryParse(simpleInterestPrinciple.Text, out double unused))
        {
            double principle = Double.Parse(simpleInterestPrinciple.Text);
            if (Double.TryParse(simpleInterestRateUserInput.Text, out double b))
            {
                double simpleRate = Double.Parse(simpleInterestRateUserInput.Text);
                if (Double.TryParse(simpleInterestYearsFutureUserInput.Text, out double stop))
                {
                    double years = Double.Parse(simpleInterestYearsFutureUserInput.Text);
                    double final = principle + ((principle * Math.Pow((simpleRate / 100), years)));
                    simpleInterestFutureValueUserInput.Text = "$" + final.ToString("0.00");

                    //checks if it is rlly changed 
                    if (principle == final)
                    {
                        simpleInterestValue.Text = "no change";
                        simpleInterestFutureValueUserInput.Text = " ";
                    }

                }
            }
        }
        else
        {
            simpleInterestValue.Text = "input values!";
        }
    }

    private void calculateCompoundInterest(object sender, RoutedEventArgs e)
    {
        if (Double.TryParse(compoundInterestPrinciplePriceUserInput.Text, out double unused))
        {
            double principle = Double.Parse(compoundInterestPrinciplePriceUserInput.Text);
            if (Double.TryParse(compoundInterestRateUserInput.Text, out double b))
            {
                double simpleRate = Double.Parse(compoundInterestRateUserInput.Text);
                if (Double.TryParse(compoundInterestYearsIntoFutureUserInput.Text, out double stop))
                {
                    double years = Double.Parse(compoundInterestYearsIntoFutureUserInput.Text);
                    double final = principle + ((principle * Math.Pow((1 + (simpleRate / 100)), years)));
                    compoundInterestFutureValueUserInput.Text = "$" + final.ToString("0.00");

                    //checks if it is rlly changed 
                    if (principle == final)
                    {
                        compoundInterestValue.Text = "no change";
                        compoundInterestFutureValueUserInput.Text = " ";
                    }

                }
            }
        }
        else
        {
            compoundInterestValue.Text = "input values!";
        }
    }

    private void inflationSeeGraph(object sender, RoutedEventArgs e)
    {
        inflationCalculator.IsVisible = false;
    }

    private void deflationSeeGraph(object sender, RoutedEventArgs e)
    {
        deflationCalculator.IsVisible = false;
    }
    private void appreciationSeeGraph(object sender, RoutedEventArgs e)
    {
        appreciationCalculator.IsVisible = false;
    }
    private void depreciationSeeGraph(object sender, RoutedEventArgs e)
    {
        depreciationCalculator.IsVisible = false;
    }

    private void simpleInterestSeeGraph(object sender, RoutedEventArgs e)
    {
        simpleInterestCalculator.IsVisible = false;
    }

    private void compoundInterestSeeGraph(object sender, RoutedEventArgs e)
    {
        compoundInterestCalculator.IsVisible = false;
    }
}
