using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using System;
using System.Data;
using static System.Net.Mime.MediaTypeNames;

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

        if (Double.TryParse(annualIncomeUserInput.Text, out double unused) && Double.TryParse(debtUserInput.Text, out double otherunused))
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
            recommendation.Text = "make sure to input income AND debt as numbers!";
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
        inflationValue.Text = "  ";
        double newPrice = -69420;
        double oldPrice = -69420;
        double rate = -69420;
        double time = -69420;
        int emptyCount = 0;
        if (Double.TryParse(inflationOldPriceUserInput.Text, out double unused))
        {
            oldPrice = Double.Parse(inflationOldPriceUserInput.Text);
        }
        else
        {
            emptyCount++;
        }
        if (Double.TryParse(inflationNewPriceUserInput.Text, out double a))
        {
            newPrice = Double.Parse(inflationNewPriceUserInput.Text);
        }
        else
        {
            emptyCount++;
        }
        if (Double.TryParse(inflationRateUserInput.Text, out double b))
        {
            rate = Double.Parse(inflationRateUserInput.Text);
        }
        else
        {
            emptyCount++;
        }
        if (Double.TryParse(inflationYearsIntoFutureUserInput.Text, out double c))
        {
            time = Double.Parse(inflationYearsIntoFutureUserInput.Text);
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
            inflationNewPriceUserInput.Text = (oldPrice * Math.Pow(1 + rate / 100, time)).ToString("0.00") + "%";
            return;
        }

        if (oldPrice == -69420)
        {
            inflationOldPriceUserInput.Text = (newPrice / Math.Pow(1 + rate / 100, time)).ToString("0.00");
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
                inflationRateUserInput.Text = "0.00";
            }
            inflationRateUserInput.Text = ((oldPrice - newPrice) / oldPrice * 100).ToString("0.00");
            return;
        }

        if (time == -69420)
        {
            if (newPrice < oldPrice)
            {
                inflationValue.Text = "this looks like deflation!";
                inflationYearsIntoFutureUserInput.Text = " ";
                return;
            }
            inflationYearsIntoFutureUserInput.Text = Math.Log(newPrice / oldPrice, 1 + rate / 100).ToString("0.00");
            return;
        }
        return;
    }


    private void calculateDeflation(object sender, RoutedEventArgs e)
    {
        deflationValue.Text = " ";
        double newPrice = -69420;
        double oldPrice = -69420;
        double rate = -69420;
        double time = -69420;
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
        if (Double.TryParse(deflationYearsIntoFutureUserInput.Text, out double c))
        {
            time = Double.Parse(deflationYearsIntoFutureUserInput.Text);
        }
        else
        {
            emptyCount++;
        }


        if (emptyCount > 1)
        {
            deflationValue.Text = "too many missing variables";
            return;
        }
        else if (emptyCount == 0)
        {
            deflationValue.Text = "no variables to solve for!";
            return;
        }

        if (newPrice == -69420)
        {
            deflationNewPriceUserInput.Text = (oldPrice * Math.Pow(1 - rate / 100, time)).ToString("0.00");
            deflationValue.Text = " ";
            return;
        }

        if (oldPrice == -69420)
        {
            deflationOldPriceUserInput.Text = (newPrice / Math.Pow(1 - rate / 100, time)).ToString("0.00");
            deflationValue.Text = " ";
            return;
        }

        if (rate == -69420)
        {
            if (newPrice > oldPrice)
            {
                deflationValue.Text = "this looks like inflation!";
                deflateRateUserInput.Text = " ";
                return;
            }
            if (oldPrice == 0 || newPrice == oldPrice)
            {
                deflateRateUserInput.Text = "0.00";
            }
            deflateRateUserInput.Text = ((oldPrice - newPrice) / oldPrice * 100).ToString("0.00");
            return;
        }

        if (time == -69420)
        {
            if (newPrice > oldPrice)
            {
                deflationValue.Text = "this looks like inflation!";
                return;
            }
            deflationYearsIntoFutureUserInput.Text = Math.Log(newPrice / oldPrice, 1 - rate / 100).ToString("0.00");
            return;
        }
        return;
    }

    private void calculateAppreciationFinal(object sender, RoutedEventArgs e)
    {
        appreciationValue.Text = "  ";
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
            appreciationValue.Text = "too many missing variables";
            return;
        }
        else if (emptyCount == 0)
        {
            appreciationValue.Text = "no variables to solve for!";
            return;
        }

        if (newPrice == -69420)
        {
            appreciationFutureValueUserInput.Text = (oldPrice * Math.Pow(1 + rate / 100, time)).ToString("0.00");
            return;
        }

        if (oldPrice == -69420)
        {
            appreciationOriginalPriceUserInput.Text = (newPrice / Math.Pow(1 + rate / 100, time)).ToString("0.00");
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
                appreciationRateUserInput.Text = "0.00";
            }
            appreciationRateUserInput.Text = ((newPrice - oldPrice) / oldPrice * 100).ToString("0.00");
            return;
        }

        if (time == -69420)
        {
            appreciationYearsIntoFuture.Text = Math.Log(newPrice / oldPrice, 1 + rate / 100).ToString("0.00");
            return;
        }
        return;

    }

    private void calculateDepreciationFinal(object sender, RoutedEventArgs e)
    {
        depreciationValue.Text = " ";
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
            depreciationValue.Text = "too many missing variables";
            return;
        }
        else if (emptyCount == 0)
        {
            depreciationValue.Text = "no variables to solve for!";
            return;
        }

        if (newPrice == -69420)
        {
            depreciationFutureValueUserInput.Text = (oldPrice * Math.Pow(1 - rate / 100, time)).ToString("0.00");
            return;
        }

        if (oldPrice == -69420)
        {
            depreciationFutureValueUserInput.Text = (newPrice / Math.Pow(1 - rate / 100, time)).ToString("0.00");
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
            depreciationRateUserInput.Text = ((oldPrice - newPrice) / oldPrice * 100).ToString("0.00");
            return;
        }

        if (time == -69420)
        {
            depreciationYearsIntoFuture.Text = Math.Log(newPrice / oldPrice, 1 - rate / 100).ToString("0.00");
            return;
        }
        return;
    }

    private void calculateSimpleInterest(object sender, RoutedEventArgs e)
    {
        simpleInterestValue.Text = "  ";
        double principle = -69420;
        double simpleRate = -69420;
        double years = -69420;
        double futureValue = -69420;
        int emptyCount = 0;
        if (Double.TryParse(simpleInterestPrinciple.Text, out double unused))
        {
            principle = Double.Parse(simpleInterestPrinciple.Text);
        }
        else
        {
            emptyCount++;
        }
        if (Double.TryParse(simpleInterestRateUserInput.Text, out double b))
        {
            simpleRate = Double.Parse(simpleInterestRateUserInput.Text);
        }
        else
        {
            emptyCount++;
        }
        if (Double.TryParse(simpleInterestYearsFutureUserInput.Text, out double stop))
        {
            years = Double.Parse(simpleInterestYearsFutureUserInput.Text);
        }
        else
        {
            emptyCount++;
        }
        if (Double.TryParse(simpleInterestFutureValueUserInput.Text, out double h))
        {
            futureValue = Double.Parse(simpleInterestFutureValueUserInput.Text);
        }
        else
        {
            emptyCount++;
        }

        if (emptyCount > 1)
        {
            simpleInterestValue.Text = "too many missing variables";
            return;
        }
        else if (emptyCount == 0)
        {
            simpleInterestValue.Text = "no variables to solve for!";
            return;
        }

        if (principle == -69420)
        {
            simpleInterestPrinciple.Text = (futureValue / (1 * (simpleRate / 100) * years)).ToString("0.##");
            return;
        }

        if (futureValue == -69420)
        {
            simpleInterestFutureValueUserInput.Text = (principle * (1 + (simpleRate / 100) * years)).ToString("0.##");
            return;
        }

        if (simpleRate == -69420)
        {
            simpleInterestRateUserInput.Text = ((((futureValue / principle) - 1) / years) * 100).ToString("0.#######");
            return;
        }

        if (years == -69420)
        {
            simpleInterestYearsFutureUserInput.Text = (((futureValue / principle) - 1) / simpleRate / 100).ToString("0.######");
            return;
        }
        return;
    }

    private void calculateCompoundInterest(object sender, RoutedEventArgs e)
    {
        simpleInterestValue.Text = "  ";
        double principle = -69420;
        double simpleRate = -69420;
        double years = -69420;
        double futureValue = -69420;
        int emptyCount = 0;
        if (Double.TryParse(compoundInterestPrinciplePriceUserInput.Text, out double unused))
        {
            principle = Double.Parse(compoundInterestPrinciplePriceUserInput.Text);
        }
        else
        {
            emptyCount++;
        }
        if (Double.TryParse(compoundInterestRateUserInput.Text, out double b))
        {
            simpleRate = Double.Parse(compoundInterestRateUserInput.Text);
        }
        else
        {
            emptyCount++;
        }
        if (Double.TryParse(compoundInterestYearsIntoFutureUserInput.Text, out double stop))
        {
            years = Double.Parse(compoundInterestYearsIntoFutureUserInput.Text);
        }
        else
        {
            emptyCount++;
        }
        if (Double.TryParse(compoundInterestFutureValueUserInput.Text, out double h))
        {
            futureValue = Double.Parse(compoundInterestFutureValueUserInput.Text);
        }
        else
        {
            emptyCount++;
        }

        if (emptyCount > 1)
        {
            simpleInterestValue.Text = "too many missing variables";
            return;
        }
        else if (emptyCount == 0)
        {
            simpleInterestValue.Text = "no variables to solve for!";
            return;
        }

        if (principle == -69420)
        {
            simpleInterestPrinciple.Text = (futureValue / Math.Pow((1 + simpleRate), years)).ToString("0.##");
            return;
        }

        if (futureValue == -69420)
        {
            simpleInterestFutureValueUserInput.Text = (principle * Math.Pow(1 + simpleRate / 100, years)).ToString("0.##");
            return;
        }

        if (simpleRate == -69420)
        {
            simpleInterestRateUserInput.Text = (Math.Pow(futureValue / principle, 1 / years) - 1).ToString("0.#######");
            return;
        }

        if (years == -69420)
        {
            simpleInterestYearsFutureUserInput.Text = (Math.Log(futureValue / principle, 1 + simpleRate / 100)).ToString("0.######");
            return;
        }
        return;

    }
}
