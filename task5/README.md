### how its work 

Import necessary libraries: pandas, matplotlib, statsmodels, sklearn, and math.

Load the dataset ('prices.txt') into a pandas dataframe using the read_csv() function.

Convert the 'Date' column of the dataframe to a datetime object using pd.to_datetime() and set it as the index of the dataframe using set_index().

Convert the index to a DatetimeIndex with a period of 1 day using pd.DatetimeIndex().to_period('d').

Fit an ARIMA model to the entire dataset using statsmodels.tsa.arima.model.ARIMA and fit().

Print a summary of the fit model using summary().


Create a line plot of the residuals of the fit model using plot() and pyplot.show().

Create a density plot of the residuals using plot(kind='kde') and pyplot.show().


Calculate summary statistics of the residuals using describe().


Split the data into a training set and a test set


Fit an ARIMA model to the training set, make forecasts on the test set, and evaluate performance


Evaluate the performance of the forecasts using root mean squared error (RMSE)


plot forecasts against actual outcomes

