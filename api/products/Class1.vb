update PremiumFundingPayments set PaymentDate = '2015-06-14' where  ApplicationId = 741584 and id = 7642
update PremiumFundingPayments set PaymentDate = '2015-07-07' where  ApplicationId = 741584 and id = 7643
update PremiumFundingPayments set PaymentDate = '2015-08-08' where  ApplicationId = 741584 and id = 7644
update PremiumFundingPayments set PaymentDate = '2015-09-07' where  ApplicationId = 741584 and id = 7645
update PremiumFundingPayments set PaymentDate = '2015-10-07' where  ApplicationId = 741584 and id = 7646
update PremiumFundingPayments set PaymentDate = '2015-11-07' where  ApplicationId = 741584 and id = 7647
update PremiumFundingPayments set PaymentDate = '2015-12-07' where  ApplicationId = 741584 and id = 7648
update PremiumFundingPayments set PaymentDate = '2016-01-09' where  ApplicationId = 741584 and id = 7649
update PremiumFundingPayments set PaymentDate = '2016-02-07' where  ApplicationId = 741584 and id = 7650
update PremiumFundingPayments set PaymentDate = '2016-03-07' where  ApplicationId = 741584 and id = 7651
update PremiumFundingPayments set PaymentDate = '2016-04-07' where  ApplicationId = 741584 and id = 7652
update PremiumFundingPayments set PaymentDate = '2016-05-08' where  ApplicationId = 741584 and id = 7653



update PremiumFunding set FirstInstalmentDate = '2015-06-14' where ApplicationId = 741584
update Application_Product set ExpiryDate = GETDATE() + 20  where ApplicationId = 741584
update Application set PolicyInceptionDate='2015-06-14' where id = 741584 

select * from PremiumFundingPaymentDetails where UserId = 'B49163D6-8E8F-45A3-9F73-1730AB1524CA'