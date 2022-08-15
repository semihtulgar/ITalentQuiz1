// See https://aka.ms/new-console-template for more information


using DependencyInversionPrincipleExample;

ICompany ilabCompany = new ILABCompany(new WelcomeToSummerParty());
ilabCompany.PrepareEvent();

ICompany emlakJetCompany = new EmlakjetCompany(new MeetParty());
emlakJetCompany.PrepareEvent();
