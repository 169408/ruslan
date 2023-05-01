import numpy as np
import matplotlib.pyplot as plt
import openpyxl
import pandas as pd
import random

zamowienia = pd.read_csv('zamowienia.csv', sep=';')
print(zamowienia)

sprzedawca = zamowienia['Sprzedawca'].unique()
sprzedawca.sort()

sumy_zamowien = zamowienia.groupby('Sprzedawca')['Utarg'].sum()

plt.pie(sumy_zamowien, labels=sprzedawca, autopct=lambda pct:"{:.1f}%".format(pct), textprops=dict(color="black"))
plt.legend(title='Sprzedawcy', loc=1)
plt.show()