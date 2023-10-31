using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
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
        if (Double.TryParse(inflationOldPriceUserInput.Text, out double unused))
        {
            double oldPrice = Double.Parse(inflationOldPriceUserInput.Text);
            if (Double.TryParse(inflationNewPriceUserInput.Text, out double a))
            {
                double newPrice = Double.Parse(inflationNewPriceUserInput.Text);
                double answer = (newPrice - oldPrice) / oldPrice * 100;
                inflationRateUserInput.Text =  answer.ToString("0.00") + "%";

                //checks if it rlly is inflation or prices r equal after tvm calculations
                if (newPrice < oldPrice)
                {
                    inflationValue.Text = "this looks like deflation!";
                    inflationRateUserInput.Text = " ";
                }
                else if (newPrice == oldPrice)
                {
                    inflationValue.Text = "no change";
                    inflationOldPriceUserInput.Text = " ";
                }
            }
        }
        else
        {
            inflationValue.Text = "input values!";
        }
    }

    private void calculateDeflation(object sender, RoutedEventArgs e)
    {
        if (Double.TryParse(deflationOldPriceUserInput.Text, out double unused))
        {
            double oldPrice = Double.Parse(deflationOldPriceUserInput.Text);
            if (Double.TryParse(deflationNewPriceUserInput.Text, out double a))
            {
                double newPrice = Double.Parse(deflationNewPriceUserInput.Text);
                double answer = (oldPrice - newPrice) / oldPrice * 100;
                deflateRateUserInput.Text = answer.ToString("0.00") + "%";

                //checks if it rlly is deflation or prices r equal after tvm calculations
                if (newPrice > oldPrice)
                {
                    deflationValue.Text = "this looks like inflation!";
                    deflateRateUserInput.Text = " ";
                }
                else if (newPrice == oldPrice)
                {
                    deflationValue.Text = "no change";
                    deflateRateUserInput.Text = " ";
                }
            }
        }
        else
        {
            deflationValue.Text = "input values!";
        }
    }


    private void calculateAppreciationFinal(object sender, RoutedEventArgs e)
    {
        if (Double.TryParse(appreciationOriginalPriceUserInput.Text, out double unused))
        {
            double originalPrice = Double.Parse(appreciationOriginalPriceUserInput.Text);
            if (Double.TryParse(appreciationRateUserInput.Text, out double a))
            {
                double rate = Double.Parse(appreciationRateUserInput.Text) / 100;
                if (Double.TryParse(appreciationYearsIntoFuture.Text, out double b))
                {
                    double years = Double.Parse(appreciationYearsIntoFuture.Text);
                    double finalPrice = originalPrice * Math.Pow(1 + rate, years);
                    appreciationFutureValueUserInput.Text = "$" + finalPrice.ToString("0.00");

                    //checks if it rlly is appreciation
                    if (finalPrice < originalPrice)
                    {
                        appreciationValue.Text = "this looks like depreciation!";
                        appreciationFutureValueUserInput.Text = " ";
                    }
                    else if (finalPrice == originalPrice)
                    {
                        appreciationValue.Text = "no change";
                        appreciationFutureValueUserInput.Text = " ";
                    }
                }
            }
        }
        else
        {
            appreciationValue.Text = "input values!";
        }
    }

    private void calculateDepreciationFinal(object sender, RoutedEventArgs e)
    {
        if (Double.TryParse(depreciationOriginalPriceUserInput.Text, out double unused))
        {
            double originalPrice = Double.Parse(depreciationOriginalPriceUserInput.Text);
            if (Double.TryParse(depreciationRateUserInput.Text, out double a))
            {
                double rate = Double.Parse(depreciationRateUserInput.Text) / 100;
                if (Double.TryParse(depreciationYearsIntoFuture.Text, out double b))
                {
                    double years = Double.Parse(depreciationYearsIntoFuture.Text);
                    double finalPrice = originalPrice - (originalPrice * Math.Pow(1 + rate, years));
                    depreciationFutureValueUserInput.Text = "$" + finalPrice.ToString();

                    //checks if it is rlly depreciation 
                    if (finalPrice == originalPrice)
                    {
                        depreciationValue.Text = "no change";
                        depreciationFutureValueUserInput.Text = " ";
                    }
                }
            }
        }
        else
        {
            depreciationValue.Text = "input values!";
        }
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

    private void inflationSeeGraph (object sender, RoutedEventArgs e)
    {
        inflationCalculator.IsVisible = false;
    }

    private void deflationSeeGraph (object sender, RoutedEventArgs e)
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
