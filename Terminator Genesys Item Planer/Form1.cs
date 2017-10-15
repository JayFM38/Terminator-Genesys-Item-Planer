using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terminator_Genesys_Item_Planer
{
    public partial class Form1 : Form
    {
        #region ItemsGenerierung
        List<KommanderItems> naviItems = new List<KommanderItems>
        {
            new KommanderItems("Frequenzmodulator", _itemSlot.navigation, 50, 500, new List<Boni> { new Boni(_boniTyp.infantrieAng, (float)20.3, true, 2), new Boni(_boniTyp.gesTruppenGes, (float)8.4, true, 1), new Boni(_boniTyp.marsch, (float)24, true, 1) }),
            new KommanderItems("Gefechtsanzeiger", _itemSlot.navigation, 49, 490, new List<Boni> { new Boni(_boniTyp.forschung, (float)23, true, 2), new Boni(_boniTyp.bau, (float)17.7, true, 1), new Boni(_boniTyp.belagerungAng, (float)15.3, true, 1) }),
            new KommanderItems("Wärmesensor", _itemSlot.navigation, 49, 490, new List<Boni> { new Boni(_boniTyp.marsch, (float)30.7, true, 2), new Boni(_boniTyp.kavallerieAng, (float)15.3, true, 1), new Boni(_boniTyp.infantrieAng, (float)15.3, true, 1) }),
            new KommanderItems("Zielsuchgerät", _itemSlot.navigation, 48, 480, new List<Boni> { new Boni(_boniTyp.munitionProd, (float)174, true, 1), new Boni(_boniTyp.iridiumProd, (float)87, true, 1), new Boni(_boniTyp.sturmtruppenAng, (float)19.6, true, 2) }),
            new KommanderItems("GPS", _itemSlot.navigation, 47, 470, new List<Boni> { new Boni(_boniTyp.iridiumProd, (float)111.2, true, 2), new Boni(_boniTyp.luftwaffeAng, (float)14.8, true, 1), new Boni(_boniTyp.sturmtruppenAng, (float)14.8, true, 1) }),
            new KommanderItems("Lichtwellendetektor", _itemSlot.navigation, 46, 460, new List<Boni> { new Boni(_boniTyp.bau, (float)16.8, true, 1), new Boni(_boniTyp.forschung, (float)16.8, true, 1), new Boni(_boniTyp.belagerungAng, (float)18.9, true, 2) }),
            new KommanderItems("Radar", _itemSlot.navigation, 45, 450, new List<Boni> { new Boni(_boniTyp.kavallerieAng, (float)18.6, true, 2), new Boni(_boniTyp.sturmtruppenAng, (float)14.3, true, 1), new Boni(_boniTyp.bau, (float)16.5, true, 1) }),
            new KommanderItems("EM-Sensor", _itemSlot.navigation, 44, 440, new List<Boni> { new Boni(_boniTyp.kavallerieAng, (float)14, true, 1), new Boni(_boniTyp.luftwaffeAng, (float)18.3, true, 2), new Boni(_boniTyp.marsch, (float)21.6, true, 1) }),
            new KommanderItems("Seismischer Sensor", _itemSlot.navigation, 43, 430, new List<Boni> { new Boni(_boniTyp.munitionProd, (float)206.7, true, 2), new Boni(_boniTyp.belagerungAng, (float)13.8, true, 1), new Boni(_boniTyp.forschung, (float)15.9, true, 1)}),
            new KommanderItems("Winkelfernrohr", _itemSlot.navigation, 42, 420, new List<Boni> { new Boni(_boniTyp.munitionProd, (float)156, true, 1), new Boni(_boniTyp.infantrieAng, (float)13.5, true, 1), new Boni(_boniTyp.gesTruppenGes, (float)9.5, true, 2) }),
            new KommanderItems("Meldesystem", _itemSlot.navigation, 41, 410, new List<Boni> { new Boni(_boniTyp.bau, (float)19.9, true, 2), new Boni(_boniTyp.gesTruppenGes, (float)6.8, true, 1), new Boni(_boniTyp.kavallerieAng, (float)13.9, true, 1)}),
            new KommanderItems("Wellenortungsgerät", _itemSlot.navigation, 40, 400, new List<Boni> { new Boni(_boniTyp.marsch, (float)24, true, 2), new Boni(_boniTyp.sturmtruppenAng, (float)13, true, 1), new Boni(_boniTyp.belagerungAng, (float)13, true, 1)})
        };

        List<KommanderItems> waffenItems = new List<KommanderItems>
        {
            new KommanderItems("Brandsatz T-1", _itemSlot.waffe, 50, 500, new List<Boni> { new Boni(_boniTyp.luftwaffeAng, (float)20.3, true, 2), new Boni(_boniTyp.gesTruppenAbw, (float)9.2, true, 1), new Boni(_boniTyp.marsch, (float)21.6, true, 1)}),
            new KommanderItems("Schweres Maschinengewehr", _itemSlot.waffe, 49, 490, new List<Boni> { new Boni(_boniTyp.sturmtruppenAng, (float)19.9, true, 2), new Boni(_boniTyp.infantrieAng, (float)15.3, true, 1), new Boni(_boniTyp.bau, (float)17.7, true, 1)}),
            new KommanderItems("Verschilinger", _itemSlot.waffe, 48, 480, new List<Boni> { new Boni(_boniTyp.gesTruppenAbw, (float)10.7, true, 2), new Boni(_boniTyp.munitionProd, (float)177, true, 1), new Boni(_boniTyp.luftwaffeAng, (float)15.3, true, 1)}),
            new KommanderItems("Sniper-Granatwerfer", _itemSlot.waffe, 48, 480, new List<Boni> { new Boni(_boniTyp.infantrieAng, (float)19.6, true, 2), new Boni(_boniTyp.kavallerieAng, (float)14.3, true, 1), new Boni(_boniTyp.gesTruppenAbw, (float)8.5, true, 1)}),
            new KommanderItems("Flammenwerfer", _itemSlot.waffe, 47, 470, new List<Boni> { new Boni(_boniTyp.forschung, (float)22.2, true, 2), new Boni(_boniTyp.sturmtruppenAng, (float)14.8, true, 1), new Boni(_boniTyp.gesTruppenAbw, (float)8, true, 1)}),
            new KommanderItems("Luis-Hochleistungsgewehr", _itemSlot.waffe, 47, 470, new List<Boni> { new Boni(_boniTyp.kavallerieAng, (float)19.3, true, 2), new Boni(_boniTyp.iridiumProd, (float)85.5, true, 1), new Boni(_boniTyp.marsch, (float)22.8, true, 1)}),
            new KommanderItems("Viehtreiber", _itemSlot.waffe, 46, 460, new List<Boni> { new Boni(_boniTyp.munitionProd, (float)218.4, true, 2), new Boni(_boniTyp.bau, (float)16.8, true, 1), new Boni(_boniTyp.forschung, (float)16.8, true, 1)}),
            new KommanderItems("Phosphorgranante", _itemSlot.waffe, 45, 450, new List<Boni> { new Boni(_boniTyp.marsch, (float)26.4, true, 2), new Boni(_boniTyp.gesTruppenGes, (float)7.7, true, 1), new Boni(_boniTyp.belagerungAng, (float)15.7, true, 1)}),
            new KommanderItems("Splittergranate", _itemSlot.waffe, 44, 440, new List<Boni> {  new Boni(_boniTyp.iridiumProd, (float)81, true, 1), new Boni(_boniTyp.belagerungAng, (float)18.3, true, 2), new Boni(_boniTyp.marsch, (float)21.6, true, 1)}),
            new KommanderItems("M-27", _itemSlot.waffe, 43, 430, new List<Boni> {  new Boni(_boniTyp.bau, (float)20.7, true, 2), new Boni(_boniTyp.kavallerieAng, (float)13.8, true, 1), new Boni(_boniTyp.luftwaffeAng, (float)13.8, true, 1)}),
            new KommanderItems("Panzerbüchse", _itemSlot.waffe, 42, 420, new List<Boni> {  new Boni(_boniTyp.sturmtruppenAng, (float)13.5, true, 1), new Boni(_boniTyp.luftwaffeAng, (float)17.6, true, 2), new Boni(_boniTyp.infantrieAng, (float)13.5, true, 1)}),
            new KommanderItems("Automatische Pistole", _itemSlot.waffe, 41, 410, new List<Boni> {  new Boni(_boniTyp.iridiumProd, (float)99.5, true, 2), new Boni(_boniTyp.munitionProd, (float)153, true, 1), new Boni(_boniTyp.forschung, (float)15.3, true, 1)}),
            new KommanderItems("N-16", _itemSlot.waffe, 40, 400, new List<Boni> {  new Boni(_boniTyp.kavallerieAng, (float)13, true, 1), new Boni(_boniTyp.gesTruppenAbw, (float)8.4, true, 2), new Boni(_boniTyp.bau, (float)15, true, 1)})
        };

        List<KommanderItems> ruestungItems = new List<KommanderItems>()
        {
            new KommanderItems("Korpuskularprojektor", _itemSlot.ruestung, 50, 500, new List<Boni> { new Boni(_boniTyp.forschung, (float)18.9, true, 1), new Boni(_boniTyp.sturmtruppenAng, (float)19.5, true, 2), new Boni(_boniTyp.gesTruppenAbw, (float)8.4, true, 1)}),
            new KommanderItems("EMI-Blocker", _itemSlot.ruestung, 49, 490, new List<Boni> { new Boni(_boniTyp.iridiumProd, (float)115.1, true, 2), new Boni(_boniTyp.forschung, (float)17.7, true, 1), new Boni(_boniTyp.bau, (float)17.7, true, 1)}),
            new KommanderItems("Leuchtrakete", _itemSlot.ruestung, 48, 480, new List<Boni> { new Boni(_boniTyp.bau, (float)17.4, true, 1), new Boni(_boniTyp.luftwaffeAng, (float)19.6, true, 2), new Boni(_boniTyp.marsch, (float)23.2, true, 1)}),
            new KommanderItems("Wellengenerator", _itemSlot.ruestung, 47, 470, new List<Boni> { new Boni(_boniTyp.belagerungAng, (float)19.3, true, 2), new Boni(_boniTyp.luftwaffeAng, (float)14.8, true, 1), new Boni(_boniTyp.munitionProd, (float)171, true, 1)}),
            new KommanderItems("NP Phantom", _itemSlot.ruestung, 46, 460, new List<Boni> { new Boni(_boniTyp.munitionProd, (float)168, true, 1), new Boni(_boniTyp.iridiumProd, (float)84, true, 1), new Boni(_boniTyp.infantrieAng, (float)18.9, true, 2)}),
            new KommanderItems("Energieschutzschild", _itemSlot.ruestung, 45, 450, new List<Boni> { new Boni(_boniTyp.gesTruppenAbw, (float)9.2, true, 2), new Boni(_boniTyp.bau, (float)18.2, true, 1), new Boni(_boniTyp.gesTruppenGes, (float)7.7, true, 1)}),
            new KommanderItems("Plasmafänger", _itemSlot.ruestung, 45, 450, new List<Boni> { new Boni(_boniTyp.marsch, (float)28.6, true, 2), new Boni(_boniTyp.belagerungAng, (float)14.3, true, 1), new Boni(_boniTyp.infantrieAng, (float)14.3, true, 1)}),
            new KommanderItems("Reperaturdrohne", _itemSlot.ruestung, 44, 440, new List<Boni> { new Boni(_boniTyp.forschung, (float)19.4, true, 2), new Boni(_boniTyp.sturmtruppenAng, (float)14, true, 0), new Boni(_boniTyp.marsch, (float)23.8, true, 2)}),
            new KommanderItems("Verschleierer", _itemSlot.ruestung, 43, 430, new List<Boni> { new Boni(_boniTyp.munitionProd, (float)206.7, true, 2), new Boni(_boniTyp.luftwaffeAng, (float)13.8, true, 1), new Boni(_boniTyp.gesTruppenGes, (float)7.4, true, 1)}),
            new KommanderItems("Luftschleuse", _itemSlot.ruestung, 42, 420, new List<Boni> { new Boni(_boniTyp.belagerungAng, (float)13.5, true, 1), new Boni(_boniTyp.kavallerieAng, (float)17.6, true, 2), new Boni(_boniTyp.gesTruppenAbw, (float)7.3, true, 1)}),
            new KommanderItems("Starliter", _itemSlot.ruestung, 41, 410, new List<Boni> { new Boni(_boniTyp.bau, (float)17.6, true, 1), new Boni(_boniTyp.infantrieAng, (float)13.3, true, 1), new Boni(_boniTyp.forschung, (float)17.6, true, 1)}),
            new KommanderItems("Feuerschutzgerät", _itemSlot.ruestung, 40, 400, new List<Boni> { new Boni(_boniTyp.bau, (float)18, true, 2), new Boni(_boniTyp.luftwaffeAng, (float)13, true, 1), new Boni(_boniTyp.sturmtruppenAng, (float)13, true, 1)}),
            new KommanderItems("Antiterm T-110", _itemSlot.ruestung, 39, 390, new List<Boni> { new Boni(_boniTyp.marsch, (float)23.5, false, 1), new Boni(_boniTyp.kavallerieAng, (float)12.7, false, 1), new Boni(_boniTyp.gesTruppenAbw, (float)6.9, false, 1)})
        };

        List<KommanderItems> geraeteItems1 = new List<KommanderItems>()
            {
            new KommanderItems("Elektr-Idendifizierer", _itemSlot.geraet1, 50, 500, new List<Boni> { new Boni(_boniTyp.iridiumProd, (float)99, true, 2), new Boni(_boniTyp.kavallerieAng, (float)20.3, true, 2), new Boni(_boniTyp.gesTruppenAbw, (float)7.6, true, 0)}),
            new KommanderItems("Nanovisier", _itemSlot.geraet1, 49, 490, new List<Boni> { new Boni(_boniTyp.luftwaffeAng, (float)21.5, true, 2), new Boni(_boniTyp.belagerungAng, (float)15.3, true, 1), new Boni(_boniTyp.munitionProd, (float)159.3, true, 1)}),
            new KommanderItems("Signalfokussierer", _itemSlot.geraet1, 49, 490, new List<Boni> { new Boni(_boniTyp.infantrieAng, (float)19.9, true, 2), new Boni(_boniTyp.kavallerieAng, (float)15.3, true, 1), new Boni(_boniTyp.munitionProd, (float)177, true, 1)}),
            new KommanderItems("Mikrokopierer", _itemSlot.geraet1, 48, 480, new List<Boni> { new Boni(_boniTyp.bau, (float)22.6, true, 2), new Boni(_boniTyp.belagerungAng, (float)15.1, true, 1), new Boni(_boniTyp.infantrieAng, (float)15.1, true, 1)}),
            new KommanderItems("Endotron", _itemSlot.geraet1, 48, 480, new List<Boni> { new Boni(_boniTyp.sturmtruppenAng, (float)19.3, true, 2), new Boni(_boniTyp.gesTruppenAbw, (float)6.8, true, 1), new Boni(_boniTyp.bau, (float)19.7, true, 1)}),
            new KommanderItems("Reperaturkit", _itemSlot.geraet1, 47, 470, new List<Boni> { new Boni(_boniTyp.belagerungAng, (float)19.3, true, 2), new Boni(_boniTyp.kavallerieAng, (float)14.8, true, 1), new Boni(_boniTyp.munitionProd, (float)171, true, 1)}),
            new KommanderItems("Laser-Entfernunfsgerät", _itemSlot.geraet1, 46, 460, new List<Boni> { new Boni(_boniTyp.forschung, (float)21.8, true, 2), new Boni(_boniTyp.sturmtruppenAng, (float)14.6, true, 1), new Boni(_boniTyp.marsch, (float)22.4, true, 1)}),
            new KommanderItems("Radialwandler", _itemSlot.geraet1, 44, 440, new List<Boni> { new Boni(_boniTyp.munitionProd, (float)162, true, 1), new Boni(_boniTyp.marsch, (float)21.6, true, 1), new Boni(_boniTyp.gesTruppenGes, (float)9.8, true, 2)}),
            new KommanderItems("Impfpistole", _itemSlot.geraet1, 42, 420, new List<Boni> { new Boni(_boniTyp.luftwaffeAng, (float)13.5, true, 1), new Boni(_boniTyp.iridiumProd, (float)101.4, true, 2), new Boni(_boniTyp.kavallerieAng, (float)13.5, true, 1)}),
            new KommanderItems("Sichtmodulator", _itemSlot.geraet1, 42, 420, new List<Boni> { new Boni(_boniTyp.marsch, (float)27, true, 2), new Boni(_boniTyp.munitionProd, (float)156, true, 1), new Boni(_boniTyp.infantrieAng, (float)13.5, true, 1)}),
            new KommanderItems("Autonomer Controller", _itemSlot.geraet1, 41, 410, new List<Boni> { new Boni(_boniTyp.munitionProd, (float)198.9, true, 2), new Boni(_boniTyp.bau, (float)15.3, true, 1), new Boni(_boniTyp.kavallerieAng, (float)13.3, true, 1)}),
            new KommanderItems("Wetteranzeiger", _itemSlot.geraet1, 40, 400, new List<Boni> { new Boni(_boniTyp.belagerungAng, (float)15, true, 2), new Boni(_boniTyp.infantrieAng, (float)15.6, true, 2), new Boni(_boniTyp.forschung, (float)14.3, true, 0)})
        };

        List<KommanderItems> geraeteItems2 = new List<KommanderItems>()
            {
            new KommanderItems("Elektr-Idendifizierer", _itemSlot.geraet2, 50, 500, new List<Boni> { new Boni(_boniTyp.iridiumProd, (float)99, true, 2), new Boni(_boniTyp.kavallerieAng, (float)20.3, true, 2), new Boni(_boniTyp.gesTruppenAbw, (float)7.6, true, 0)}),
            new KommanderItems("Nanovisier", _itemSlot.geraet2, 49, 490, new List<Boni> { new Boni(_boniTyp.luftwaffeAng, (float)21.5, true, 2), new Boni(_boniTyp.belagerungAng, (float)15.3, true, 1), new Boni(_boniTyp.munitionProd, (float)159.3, true, 1)}),
            new KommanderItems("Signalfokussierer", _itemSlot.geraet2, 49, 490, new List<Boni> { new Boni(_boniTyp.infantrieAng, (float)19.9, true, 2), new Boni(_boniTyp.kavallerieAng, (float)15.3, true, 1), new Boni(_boniTyp.munitionProd, (float)177, true, 1)}),
            new KommanderItems("Mikrokopierer", _itemSlot.geraet2, 48, 480, new List<Boni> { new Boni(_boniTyp.bau, (float)22.6, true, 2), new Boni(_boniTyp.belagerungAng, (float)15.1, true, 1), new Boni(_boniTyp.infantrieAng, (float)15.1, true, 1)}),
            new KommanderItems("Endotron", _itemSlot.geraet2, 48, 480, new List<Boni> { new Boni(_boniTyp.sturmtruppenAng, (float)19.3, true, 2), new Boni(_boniTyp.gesTruppenAbw, (float)6.8, true, 1), new Boni(_boniTyp.bau, (float)19.7, true, 1)}),
            new KommanderItems("Reperaturkit", _itemSlot.geraet2, 47, 470, new List<Boni> { new Boni(_boniTyp.belagerungAng, (float)19.3, true, 2), new Boni(_boniTyp.kavallerieAng, (float)14.8, true, 1), new Boni(_boniTyp.munitionProd, (float)171, true, 1)}),
            new KommanderItems("Laser-Entfernunfsgerät", _itemSlot.geraet2, 46, 460, new List<Boni> { new Boni(_boniTyp.forschung, (float)21.8, true, 2), new Boni(_boniTyp.sturmtruppenAng, (float)14.6, true, 1), new Boni(_boniTyp.marsch, (float)22.4, true, 1)}),
            new KommanderItems("Radialwandler", _itemSlot.geraet2, 44, 440, new List<Boni> { new Boni(_boniTyp.munitionProd, (float)162, true, 1), new Boni(_boniTyp.marsch, (float)21.6, true, 1), new Boni(_boniTyp.gesTruppenGes, (float)9.8, true, 2)}),
            new KommanderItems("Impfpistole", _itemSlot.geraet2, 42, 420, new List<Boni> { new Boni(_boniTyp.luftwaffeAng, (float)13.5, true, 1), new Boni(_boniTyp.iridiumProd, (float)101.4, true, 2), new Boni(_boniTyp.kavallerieAng, (float)13.5, true, 1)}),
            new KommanderItems("Sichtmodulator", _itemSlot.geraet2, 42, 420, new List<Boni> { new Boni(_boniTyp.marsch, (float)27, true, 2), new Boni(_boniTyp.munitionProd, (float)156, true, 1), new Boni(_boniTyp.infantrieAng, (float)13.5, true, 1)}),
            new KommanderItems("Autonomer Controller", _itemSlot.geraet2, 41, 410, new List<Boni> { new Boni(_boniTyp.munitionProd, (float)198.9, true, 2), new Boni(_boniTyp.bau, (float)15.3, true, 1), new Boni(_boniTyp.kavallerieAng, (float)13.3, true, 1)}),
            new KommanderItems("Wetteranzeiger", _itemSlot.geraet2, 40, 400, new List<Boni> { new Boni(_boniTyp.belagerungAng, (float)15, true, 2), new Boni(_boniTyp.infantrieAng, (float)15.6, true, 2), new Boni(_boniTyp.forschung, (float)14.3, true, 0)})
        };

        List<KommanderItems> optimiererItems = new List<KommanderItems>()
        {
            new KommanderItems("Hitzestabilisierungsmodul", _itemSlot.optimierer, 50, 500, new List<Boni> { new Boni(_boniTyp.belagerungAng, (float)20.3, true, 2), new Boni(_boniTyp.luftwaffeAng, (float)15.6, true, 1), new Boni(_boniTyp.gesTruppenGes, (float)8.4, true, 1)}),
            new KommanderItems("Haltbarkeitsmodul", _itemSlot.optimierer, 49, 490, new List<Boni> { new Boni(_boniTyp.munitionProd, (float)230.1, true, 2), new Boni(_boniTyp.gesTruppenAbw, (float)8.3, true, 1), new Boni(_boniTyp.luftwaffeAng, (float)15.3, true, 1)}),
            new KommanderItems("Verstärkungsknoten", _itemSlot.optimierer, 49, 490, new List<Boni> { new Boni(_boniTyp.forschung, (float)23.9, true, 2), new Boni(_boniTyp.gesTruppenGes, (float)8.3, true, 1), new Boni(_boniTyp.kavallerieAng, (float)14.6, true, 1)}),
            new KommanderItems("Analysemodul", _itemSlot.optimierer, 48, 480, new List<Boni> { new Boni(_boniTyp.bau, (float)20, true, 2), new Boni(_boniTyp.forschung, (float)19.1, true, 1), new Boni(_boniTyp.luftwaffeAng, (float)15.8, true, 1)}),
            new KommanderItems("Energiesparchip", _itemSlot.optimierer, 50, 500, new List<Boni> { new Boni(_boniTyp.kavallerieAng, (float)19.3, true, 2), new Boni(_boniTyp.sturmtruppenAng, (float)14.8, true, 1), new Boni(_boniTyp.munitionProd, (float)171, true, 1)}),
            new KommanderItems("Schallschluckendes Modul", _itemSlot.optimierer, 47, 470, new List<Boni> { new Boni(_boniTyp.iridiumProd, (float)111.2, true, 2), new Boni(_boniTyp.belagerungAng, (float)14.8, true, 1), new Boni(_boniTyp.infantrieAng, (float)14.8, true, 1)}),
            new KommanderItems("Elesktrischer Impulschip", _itemSlot.optimierer, 46, 460, new List<Boni> { new Boni(_boniTyp.iridiumProd, (float)92.4, true, 1), new Boni(_boniTyp.kavallerieAng, (float)14.6, true, 1), new Boni(_boniTyp.marsch, (float)26.9, true, 2)}),
            new KommanderItems("Feuerwiederstandsmodul", _itemSlot.optimierer, 45, 450, new List<Boni> { new Boni(_boniTyp.gesTruppenAbw, (float)10, true, 2), new Boni(_boniTyp.forschung, (float)16.5, true, 1), new Boni(_boniTyp.bau, (float)16.5, true, 1)}),
            new KommanderItems("Manipulator", _itemSlot.optimierer, 44, 440, new List<Boni> { new Boni(_boniTyp.munitionProd, (float)162, true, 1), new Boni(_boniTyp.sturmtruppenAng, (float)18.3, true, 2), new Boni(_boniTyp.infantrieAng, (float)14, true, 1)}),
            new KommanderItems("Zyklusbeschleuniger", _itemSlot.optimierer, 43, 430, new List<Boni> { new Boni(_boniTyp.infantrieAng, (float)17.9, true, 2), new Boni(_boniTyp.kavallerieAng, (float)13.8, true, 1), new Boni(_boniTyp.marsch, (float)21.2, true, 1)}),
            new KommanderItems("Stickstoffmodul", _itemSlot.optimierer, 42, 420, new List<Boni> { new Boni(_boniTyp.luftwaffeAng, (float)14.2, true, 1), new Boni(_boniTyp.belagerungAng, (float)16.2, true, 2), new Boni(_boniTyp.gesTruppenAbw, (float)7.6, true, 1)}),
            new KommanderItems("Modularer Umordner", _itemSlot.optimierer, 41, 410, new List<Boni> { new Boni(_boniTyp.luftwaffeAng, (float)17.2, true, 2), new Boni(_boniTyp.munitionProd, (float)153, true, 1), new Boni(_boniTyp.gesTruppenGes, (float)7.1, true, 1)}),
            new KommanderItems("Beschleunigungsmodul", _itemSlot.optimierer, 40, 400, new List<Boni> { new Boni(_boniTyp.marsch, (float)21, true, 1), new Boni(_boniTyp.forschung, (float)15.8, true, 1), new Boni(_boniTyp.bau, (float)18, true, 2)})/*,            
            new KommanderItems("", _itemSlot.optimierer, 50, 500, new List<Boni> { })*/
        };

        List<List<KommanderItems>> alleItems;
        #endregion ItemsGenerierung

        Thread thread;

        Set altesSet;
        Set neuesSet;
        Set autoSetup;

        List<Set> bestSets;

        List<ComboBox> oldSetCbx, newSetCbx;

        Dictionary<Komponenten, int> vorhandenKomponenten;

        public Form1()
        {
            InitializeComponent();
            
            altesSet = new Set(new List<KommanderItems> { naviItems[0], optimiererItems[0], ruestungItems[0], waffenItems[0], geraeteItems1[0], geraeteItems2[0] }, null);    // Initialisieren der Sets
            neuesSet = new Set(new List<KommanderItems> { naviItems[0], optimiererItems[0], ruestungItems[0], waffenItems[0], geraeteItems1[0], geraeteItems2[0] }, null);
            autoSetup = new Set(new List<KommanderItems> {
                new KommanderItems("Dummy", _itemSlot.navigation, 1, 1, new List<Boni> { new Boni(_boniTyp.infantrieAng, (float)0, true, 0), new Boni(_boniTyp.gesTruppenGes, (float)0, true, 0), new Boni(_boniTyp.marsch, (float)0, true, 0) }),
                new KommanderItems("Dummy", _itemSlot.optimierer, 1, 1, new List<Boni> { new Boni(_boniTyp.infantrieAng, (float)0, true, 0), new Boni(_boniTyp.gesTruppenGes, (float)0, true, 0), new Boni(_boniTyp.marsch, (float)0, true, 0) }),
                new KommanderItems("Dummy", _itemSlot.ruestung, 1, 1, new List<Boni> { new Boni(_boniTyp.infantrieAng, (float)0, true, 0), new Boni(_boniTyp.gesTruppenGes, (float)0, true, 0), new Boni(_boniTyp.marsch, (float)0, true, 0) }),
                new KommanderItems("Dummy", _itemSlot.waffe, 1, 1, new List<Boni> { new Boni(_boniTyp.infantrieAng, (float)0, true, 0), new Boni(_boniTyp.gesTruppenGes, (float)0, true, 0), new Boni(_boniTyp.marsch, (float)0, true, 0) }),
                new KommanderItems("Dummy", _itemSlot.geraet1, 1, 1, new List<Boni> { new Boni(_boniTyp.infantrieAng, (float)0, true, 0), new Boni(_boniTyp.gesTruppenGes, (float)0, true, 0), new Boni(_boniTyp.marsch, (float)0, true, 0) }),
                new KommanderItems("Dummy", _itemSlot.geraet2, 1, 1, new List<Boni> { new Boni(_boniTyp.infantrieAng, (float)0, true, 0), new Boni(_boniTyp.gesTruppenGes, (float)0, true, 0), new Boni(_boniTyp.marsch, (float)0, true, 0) })
            }, null);

            oldSetCbx = new List<ComboBox> { cb_navigation_old, cb_ruestung_old, cb_optimierer_old, cb_waffen_old, cb_geraet1_old, cb_geraet2_old };                    // Initialisierung der ComboBox
            newSetCbx = new List<ComboBox> { cb_navigation, cb_ruestung, cb_optimierer, cb_waffen, cb_geraet1, cb_geraet2 };
            alleItems = new List<List<KommanderItems>> { naviItems, ruestungItems, optimiererItems, waffenItems, geraeteItems1, geraeteItems2 };

            vorhandenKomponenten = new Dictionary<Komponenten, int>();                                                                                                  // Initialisierung der vorhanden Komponenentenliste

            foreach (Komponenten con in Komponenten._komponenten)
            {
                vorhandenKomponenten.Add(con, 0);
            }           

            #region Item ComboBox DataSource Definitionen
            int i = 0;
            foreach (ComboBox cb in newSetCbx)
            {                
                cb.DataSource = alleItems.ElementAt(i++);
            }

            i = 0;            
            foreach(ComboBox cb in oldSetCbx)
            {
                cb.BindingContext = new BindingContext();
                cb.DataSource = alleItems.ElementAt(i++);
            }
            #endregion Item ComboBox DataSource Definitionen
            
            label15.Width = 150;

            initListView(lw_boni, new Dictionary<string, int> { { "Boni", 180 }, { "Altes Set", 65 }, { "Neues Set", 65 }, { "Delta", 65 } });                          // ListView Initialisierungen
            initListView(lw_components, new Dictionary<string, int> { { "Komponente", 100 }, { "need", 45 }, { "have", 45 }, { "miss", 45 } });
            initListView(lw_autosetup, new Dictionary<string, int> { { "Summe", 50 }, { "Navigation", 100 }, { "Rüstung", 100 }, { "Waffe", 100 }, { "Optimierer", 100 }, { "Gerät1", 100 }, { "Gerät2", 100 } });
            initListView(lw_overview, new Dictionary<string, int> { { "Boni", 175 }, { "Wert", 45 }, { "Komponente", 110 }, { "Anzahl", 70 } });
            
            #region Tag Definitionen
            tb_diamant.Tag = Komponenten.getKomponenteByName("Diamant");                                                                                                // Komponenten zu TextBox-Tags zuordnen
            tb_aerogel.Tag = Komponenten.getKomponenteByName("Aerogel");
            tb_kupfer.Tag = Komponenten.getKomponenteByName("Kupfer");
            tb_stahl.Tag = Komponenten.getKomponenteByName("Stahl");
            tb_microdraht.Tag = Komponenten.getKomponenteByName("Microdraht");
            tb_nanokomposit.Tag = Komponenten.getKomponenteByName("Nanokomposit");
            tb_wolfram.Tag = Komponenten.getKomponenteByName("Wolfram");
            tb_aramit.Tag = Komponenten.getKomponenteByName("Aramit");
            tb_silizium.Tag = Komponenten.getKomponenteByName("Silizium");
            tb_plastik.Tag = Komponenten.getKomponenteByName("Plastik");
            tb_magnet.Tag = Komponenten.getKomponenteByName("Magnet");
            tb_kevlar.Tag = Komponenten.getKomponenteByName("Kevlar");

            tb_man_abwehr.Tag = _boniTyp.gesTruppenAbw;
            tb_man_bau.Tag = _boniTyp.bau;
            tb_man_belagerung.Tag = _boniTyp.belagerungAng;
            tb_man_forsch.Tag = _boniTyp.forschung;
            tb_man_gesundheit.Tag = _boniTyp.gesTruppenGes;
            tb_man_infantrie.Tag = _boniTyp.infantrieAng;
            tb_man_iridium.Tag = _boniTyp.iridiumProd;
            tb_man_kav.Tag = _boniTyp.kavallerieAng;
            tb_man_luft.Tag = _boniTyp.luftwaffeAng;
            tb_man_marsch.Tag = _boniTyp.marsch;
            tb_man_muni.Tag = _boniTyp.munitionProd;
            tb_man_sturm.Tag = _boniTyp.sturmtruppenAng;

            cb_man_abwehr.Tag = _boniTyp.gesTruppenAbw;
            cb_man_bau.Tag = _boniTyp.bau;
            cb_man_belagerung.Tag = _boniTyp.belagerungAng;
            cb_man_forsch.Tag = _boniTyp.forschung;
            cb_man_gesundheit.Tag = _boniTyp.gesTruppenGes;
            cb_man_inf.Tag = _boniTyp.infantrieAng;
            cb_man_iridium.Tag = _boniTyp.iridiumProd;
            cb_man_kav.Tag = _boniTyp.kavallerieAng;
            cb_man_luft.Tag = _boniTyp.luftwaffeAng;
            cb_man_marsch.Tag = _boniTyp.marsch;
            cb_man_muni.Tag = _boniTyp.munitionProd;
            cb_man_sturm.Tag = _boniTyp.sturmtruppenAng;

            button_accept_Set_new.Tag = neuesSet;
            button_accept_Set_old.Tag = altesSet;
            button_clear_Set_new.Tag = neuesSet;
            button_clear_Set_old.Tag = altesSet;
            #endregion Tag Definitionen
        }

        /// <summary>
        /// Initialisierung und Spaltenbildung eines ListViews
        /// </summary>
        /// <param name="view"></param>
        /// <param name="elements"></param>
        private void initListView(ListView view, Dictionary<string, int> elements)
        {
            view.View = View.Details;                                                                                                                            // Boni-ListView initialisieren
            view.GridLines = true;
            view.FullRowSelect = true;

            foreach(string s in elements.Keys)
            {
                view.Columns.Add(s, elements[s]);
            }            
        }

        /// <summary>
        /// Setzt die ComboBox-Auswahl auf den angegebenen Set um
        /// </summary>
        /// <param name="aktSet"></param>
        private void setSetToComboBox(List<ComboBox>cbs, Set aktSet)
        {
            cbs.ElementAt(0).SelectedItem = aktSet.navigation;
            cbs.ElementAt(1).SelectedItem = aktSet.ruestung;
            cbs.ElementAt(2).SelectedItem = aktSet.optimierer;
            cbs.ElementAt(3).SelectedItem = aktSet.waffe;
            cbs.ElementAt(4).SelectedItem = aktSet.geraet1;
            cbs.ElementAt(5).SelectedItem = aktSet.geraet2;           

            recalculate(neuesSet);            
        }

        /// <summary>
        /// Generiert abhängig der ComboBox-Auswahl das Set
        /// </summary>
        /// <param name="aktSet"></param>
        private void setComboBoxToSet(List<ComboBox> cbs, Set aktSet)
        {
            aktSet.navigation = (KommanderItems)cbs.ElementAt(0).SelectedItem;
            aktSet.ruestung = (KommanderItems)cbs.ElementAt(1).SelectedItem;
            aktSet.optimierer = (KommanderItems)cbs.ElementAt(2).SelectedItem;
            aktSet.waffe = (KommanderItems)cbs.ElementAt(3).SelectedItem;
            aktSet.geraet1 = (KommanderItems)cbs.ElementAt(4).SelectedItem;
            aktSet.geraet2 = (KommanderItems)cbs.ElementAt(5).SelectedItem;

            recalculate(neuesSet);            
        }

        private void recalculate(Set aktSet)
        {
            Dictionary<_boniTyp, float> alt = altesSet.getBoniSetSummary();
            Dictionary<_boniTyp, float> neu = aktSet.getBoniSetSummary();

            lw_boni.Items.Clear();

            string[] arr = new string[4];
            ListViewItem itm;

            foreach (_boniTyp typ in Enum.GetValues(typeof(_boniTyp)))
            {
                float oldTmp, newTmp;

                oldTmp = checkManualMode(typ);

                if (oldTmp == -1 && !alt.TryGetValue(typ, out oldTmp))
                    oldTmp = 0;
                if (!neu.TryGetValue(typ, out newTmp))
                    newTmp = 0;

                float delta = (newTmp - oldTmp);

                arr[0] = Boni.getNameByType(typ);
                arr[1] = oldTmp.ToString("n1");
                arr[2] = newTmp.ToString("n1");
                arr[3] = delta.ToString("n1");

                itm = new ListViewItem(arr);

                Color deltaColor;
                if (delta == 0)
                {
                    itm.ForeColor = Color.Gray;
                }
                else
                {
                    if (delta < 0)
                    {
                        deltaColor = Color.Red;
                    }
                    else
                    {
                        deltaColor = Color.Green;
                    }

                    itm.SubItems[3].BackColor = deltaColor;
                    itm.UseItemStyleForSubItems = false;
                }

                lw_boni.Items.Add(itm);
            }

            refreshKomponentenView(aktSet);
        }

        private void refreshKomponentenView(Set akt)
        {
            Dictionary<Komponenten, int> komNeeded = akt.getKomponentenSetSummary();

            lw_components.Items.Clear();

            string[] arr = new string[4];
            ListViewItem itm;
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(22, 22);

            foreach (Komponenten con in komNeeded.Keys)
            {
                int anzahl;
                if (!komNeeded.TryGetValue(con, out anzahl))
                    anzahl = 0;

                int vorhanden;
                if (!vorhandenKomponenten.TryGetValue(con, out vorhanden))
                    vorhanden = 0;

                int delta = (Math.Max(0, anzahl - vorhanden));

                arr[0] = con.name;
                arr[1] = anzahl.ToString();
                arr[2] = vorhanden.ToString();
                arr[3] = delta.ToString();

                itm = new ListViewItem(arr);

                if (delta == 0)
                {
                    itm.ForeColor = Color.Gray;
                }
                else
                {
                    itm.SubItems[3].BackColor = Color.Red;
                    itm.UseItemStyleForSubItems = false;
                }

                itm.ImageIndex = lw_components.Items.Count;
                lw_components.Items.Add(itm);
                imageList.Images.Add(con.bild);
            }
            
            lw_components.SmallImageList = imageList;
        }

        private void refreshAutoGenerateView (List<Set> bestList)
        {
            lw_autosetup.Items.Clear();

            foreach (Set s in bestList)
            {
                if (s.navigation.ToString() == "Dummy")
                    break;

                Dictionary<_boniTyp, float> alt = altesSet.getBoniSetSummary();
                Dictionary<_boniTyp, float> neu = s.getBoniSetSummary();

                string[] arr = new string[7];
                ListViewItem itm;

                float sum = 0;

                foreach (_boniTyp typ in Enum.GetValues(typeof(_boniTyp)))
                {
                    float oldTmp, newTmp;

                    oldTmp = checkManualMode(typ);

                    if (oldTmp == -1 && !alt.TryGetValue(typ, out oldTmp))
                        oldTmp = 0;
                    if (!neu.TryGetValue(typ, out newTmp))
                        newTmp = 0;

                    sum += Boni.getFactorByType(typ) * (newTmp - oldTmp);
                }

                arr[0] = sum.ToString("n1");
                arr[1] = s.navigation.ToString();
                arr[2] = s.ruestung.ToString();
                arr[3] = s.waffe.ToString();
                arr[4] = s.optimierer.ToString();
                arr[5] = s.geraet1.ToString();
                arr[6] = s.geraet2.ToString();

                itm = new ListViewItem(arr);

                Color deltaColor;
                if (sum == 0)
                {
                    itm.ForeColor = Color.Gray;
                }
                else
                {
                    if (sum < 0)
                    {
                        deltaColor = Color.Red;
                    }
                    else
                    {
                        deltaColor = Color.Green;
                    }

                    itm.SubItems[0].BackColor = deltaColor;
                    itm.UseItemStyleForSubItems = false;
                }

                lw_autosetup.Items.Add(itm);
            }
        }

        private void refreshItemUebersicht(KommanderItems aktItem)
        {
            List<Boni> bonis = aktItem.getBoniListe();            

            lw_overview.Items.Clear();

            string[] arr = new string[4];
            ListViewItem itm;

            foreach (Boni bon in bonis)
            {
                arr[0] = Boni.getNameByType(bon.typ);
                arr[1] = bon.wert.ToString("n1");
                arr[2] = bon.ab40.name;
                arr[3] = bon.anzahlKomponente.ToString();

                itm = new ListViewItem(arr);
                lw_overview.Items.Add(itm);
            }
        }

        /// <summary>
        /// Überprüft ob die Checkboxen für die SetBoni ausgewählt sind und gibt den Wert der entsprechenden TextBox zurück.
        /// </summary>
        /// <param name="typ"></param>
        /// <returns></returns>
        private float checkManualMode(_boniTyp typ)
        {
            Dictionary<_boniTyp, TextBox> tbManualListe = new Dictionary<_boniTyp, TextBox>
            {
                {_boniTyp.gesTruppenAbw, tb_man_abwehr },
                {_boniTyp.bau, tb_man_bau },
                {_boniTyp.belagerungAng, tb_man_belagerung },
                {_boniTyp.forschung, tb_man_forsch },
                {_boniTyp.gesTruppenGes, tb_man_gesundheit},
                {_boniTyp.infantrieAng, tb_man_infantrie },
                {_boniTyp.iridiumProd, tb_man_iridium },
                {_boniTyp.kavallerieAng, tb_man_kav},
                {_boniTyp.luftwaffeAng, tb_man_luft},
                {_boniTyp.marsch, tb_man_marsch},
                {_boniTyp.munitionProd, tb_man_muni},
                {_boniTyp.sturmtruppenAng, tb_man_sturm}
            };

            Dictionary<_boniTyp, CheckBox> cbManualListe = new Dictionary<_boniTyp, CheckBox>
            {
                {_boniTyp.gesTruppenAbw, cb_man_abwehr },
                {_boniTyp.bau, cb_man_bau },
                {_boniTyp.belagerungAng, cb_man_belagerung },
                {_boniTyp.forschung, cb_man_forsch },
                {_boniTyp.gesTruppenGes, cb_man_gesundheit},
                {_boniTyp.infantrieAng, cb_man_inf },
                {_boniTyp.iridiumProd, cb_man_iridium },
                {_boniTyp.kavallerieAng, cb_man_kav},
                {_boniTyp.luftwaffeAng, cb_man_luft},
                {_boniTyp.marsch, cb_man_marsch},
                {_boniTyp.munitionProd, cb_man_muni},
                {_boniTyp.sturmtruppenAng, cb_man_sturm}
            };

            float ret;
            if (cbManualListe[typ].Checked && float.TryParse(tbManualListe[typ].Text, out ret))
                return ret;
            else
                return -1;
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = ((TextBox)sender);

            int n;

            if(int.TryParse(tb.Text, out n))
                vorhandenKomponenten[(Komponenten)tb.Tag] = n;

            refreshKomponentenView(neuesSet);
        }
       
        #region Auto Generate Thread
        delegate void SetProgressBarValueCallback(int value);
        delegate void SetLabelTextCallback(String text);
        delegate object GetComboBoxSelectedItemCallback(ComboBox cbx);
        delegate int GetBestenlisteAnzCallback();

        public event EventHandler EndAutoSetEvent;
        bool _isRunning = false;

        private void button2_Click(object sender, EventArgs e)
        {
            if (_isRunning)
            {
                EndAutoSetEvent -= endAutoSet;
                abortAutoGeneration();
                prepareThreadEnd();                
            }
            else
            {
                EndAutoSetEvent += endAutoSet;
                Boni.refreshFactorList();               // Boni Faktoren aus den Settings aktualisieren
                label15.Visible = true;
                progressBar_autoSetup.Visible = true;
                button2.Text = "Abbrechen";
                thread = new Thread(new ThreadStart(searchBest));
                thread.Start(); 
                _isRunning = true;              
            }
        }

        private void prepareThreadEnd()
        {
            progressBar_autoSetup.Value = 100;
            progressBar_autoSetup.Visible = false;
            button2.Text = "Auto Generate";
            label15.Visible = false;
            _isRunning = false;
        }

        private void abortAutoGeneration()
        {
            if (thread.IsAlive)
                thread.Abort();
        }
        
        private void endAutoSet(object sender, EventArgs arg)
        {
            prepareThreadEnd();
            refreshAutoGenerateView(bestSets);                        
        }

        private void SetProgressbarValue(int value)
        {
            if (this.progressBar_autoSetup.InvokeRequired)
            {
                SetProgressBarValueCallback d = new SetProgressBarValueCallback(SetProgressbarValue);
                this.Invoke(d, new object[] { value });
            }
            else
            {
                this.progressBar_autoSetup.Value = value;
            }
        }

        private void SetLabelText(String text)
        {
            if (this.progressBar_autoSetup.InvokeRequired)
            {
                SetLabelTextCallback d = new SetLabelTextCallback(SetLabelText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.label15.Text = text;
            }
        }

        private object GetComboBoxSelectedItem(ComboBox cbx)
        {
            if (cbx.InvokeRequired)
            {
                GetComboBoxSelectedItemCallback d = new GetComboBoxSelectedItemCallback(GetComboBoxSelectedItem);
                return this.Invoke(d, new object[] { cbx });
            }
            else
            {
                return cbx.SelectedItem;
            }
        }

        private int GetBestenlisteAnz( )
        {
            if (this.progressBar_autoSetup.InvokeRequired)
            {
                GetBestenlisteAnzCallback d = new GetBestenlisteAnzCallback(GetBestenlisteAnz);
                return (int)this.Invoke( d );
            }
            else
            {                
                return Convert.ToInt32(this.tb_anz_bestenliste.Text);
            }
        }

        public void searchBest()
        { 
            int count = 0;
            int anzahlErgebinsse = GetBestenlisteAnz();

            bestSets = new List<Set>();

            for (int i = 0; i < anzahlErgebinsse; i++)
            {
                bestSets.Add(new Set(new List<KommanderItems> {
                new KommanderItems("Dummy", _itemSlot.navigation, 1, 1, new List<Boni> { new Boni(_boniTyp.infantrieAng, (float)0, true, 0), new Boni(_boniTyp.gesTruppenGes, (float)0, true, 0), new Boni(_boniTyp.marsch, (float)0, true, 0) }),
                new KommanderItems("Dummy", _itemSlot.optimierer, 1, 1, new List<Boni> { new Boni(_boniTyp.infantrieAng, (float)0, true, 0), new Boni(_boniTyp.gesTruppenGes, (float)0, true, 0), new Boni(_boniTyp.marsch, (float)0, true, 0) }),
                new KommanderItems("Dummy", _itemSlot.ruestung, 1, 1, new List<Boni> { new Boni(_boniTyp.infantrieAng, (float)0, true, 0), new Boni(_boniTyp.gesTruppenGes, (float)0, true, 0), new Boni(_boniTyp.marsch, (float)0, true, 0) }),
                new KommanderItems("Dummy", _itemSlot.waffe, 1, 1, new List<Boni> { new Boni(_boniTyp.infantrieAng, (float)0, true, 0), new Boni(_boniTyp.gesTruppenGes, (float)0, true, 0), new Boni(_boniTyp.marsch, (float)0, true, 0) }),
                new KommanderItems("Dummy", _itemSlot.geraet1, 1, 1, new List<Boni> { new Boni(_boniTyp.infantrieAng, (float)0, true, 0), new Boni(_boniTyp.gesTruppenGes, (float)0, true, 0), new Boni(_boniTyp.marsch, (float)0, true, 0) }),
                new KommanderItems("Dummy", _itemSlot.geraet2, 1, 1, new List<Boni> { new Boni(_boniTyp.infantrieAng, (float)0, true, 0), new Boni(_boniTyp.gesTruppenGes, (float)0, true, 0), new Boni(_boniTyp.marsch, (float)0, true, 0) })
                }, null)
               );
            }

            SetProgressbarValue(0);

            int gesAnzahl;

            Set neu = new Set(new List<KommanderItems> {
                new KommanderItems("Dummy", _itemSlot.navigation, 1, 1, new List<Boni> { new Boni(_boniTyp.infantrieAng, (float)0, true, 0), new Boni(_boniTyp.gesTruppenGes, (float)0, true, 0), new Boni(_boniTyp.marsch, (float)0, true, 0) }),
                new KommanderItems("Dummy", _itemSlot.optimierer, 1, 1, new List<Boni> { new Boni(_boniTyp.infantrieAng, (float)0, true, 0), new Boni(_boniTyp.gesTruppenGes, (float)0, true, 0), new Boni(_boniTyp.marsch, (float)0, true, 0) }),
                new KommanderItems("Dummy", _itemSlot.ruestung, 1, 1, new List<Boni> { new Boni(_boniTyp.infantrieAng, (float)0, true, 0), new Boni(_boniTyp.gesTruppenGes, (float)0, true, 0), new Boni(_boniTyp.marsch, (float)0, true, 0) }),
                new KommanderItems("Dummy", _itemSlot.waffe, 1, 1, new List<Boni> { new Boni(_boniTyp.infantrieAng, (float)0, true, 0), new Boni(_boniTyp.gesTruppenGes, (float)0, true, 0), new Boni(_boniTyp.marsch, (float)0, true, 0) }),
                new KommanderItems("Dummy", _itemSlot.geraet1, 1, 1, new List<Boni> { new Boni(_boniTyp.infantrieAng, (float)0, true, 0), new Boni(_boniTyp.gesTruppenGes, (float)0, true, 0), new Boni(_boniTyp.marsch, (float)0, true, 0) }),
                new KommanderItems("Dummy", _itemSlot.geraet2, 1, 1, new List<Boni> { new Boni(_boniTyp.infantrieAng, (float)0, true, 0), new Boni(_boniTyp.gesTruppenGes, (float)0, true, 0), new Boni(_boniTyp.marsch, (float)0, true, 0) })
            }, null);

            List < KommanderItems > tmpNavi = (cb_keep_navi.Checked ? new List<KommanderItems> { (KommanderItems)GetComboBoxSelectedItem(cb_navigation) } : naviItems);
            gesAnzahl = tmpNavi.Count;
            List<KommanderItems> tmpRus = (cb_keep_ruestung.Checked ? new List<KommanderItems> { (KommanderItems)GetComboBoxSelectedItem(cb_ruestung) } : ruestungItems);
            gesAnzahl *= tmpRus.Count;
            List<KommanderItems> tmpWaf = (cb_keep_waffe.Checked ? new List<KommanderItems> { (KommanderItems)GetComboBoxSelectedItem(cb_waffen) } : waffenItems);
            gesAnzahl *= tmpWaf.Count;
            List<KommanderItems> tmpOpt = (cb_keep_opti.Checked ? new List<KommanderItems> { (KommanderItems)GetComboBoxSelectedItem(cb_optimierer) } : optimiererItems);
            gesAnzahl *= tmpOpt.Count;
            List<KommanderItems> tmpGer1 = (cb_keep_geraet1.Checked ? new List<KommanderItems> { (KommanderItems)GetComboBoxSelectedItem(cb_geraet1) } : geraeteItems1);
            gesAnzahl *= tmpGer1.Count;
            List<KommanderItems> tmpGer2 = (cb_keep_geraet2.Checked ? new List<KommanderItems> { (KommanderItems)GetComboBoxSelectedItem(cb_geraet2) } : geraeteItems2);
            gesAnzahl *= tmpGer2.Count;

            foreach (KommanderItems comNav in tmpNavi)
            {
                neu.navigation = comNav;                
                foreach (KommanderItems comRus in tmpRus)
                {                    
                    neu.ruestung = comRus;                    
                    foreach (KommanderItems comWaf in tmpWaf)
                    {                        
                        neu.waffe = comWaf;                        
                        foreach (KommanderItems comOpt in tmpOpt)
                        {                            
                            neu.optimierer = comOpt;                            
                            foreach (KommanderItems comGer1 in tmpGer1)
                            {
                                neu.geraet1 = comGer1;                                
                                foreach (KommanderItems comGer2 in tmpGer2)
                                {
                                    neu.geraet2 = comGer2;
                                    if (!cb_auto_vorhanden_beruecksichtigen.Checked || missingKompTolerated(neu, Convert.ToInt32(tb_auto_maxAbweichung.Text)))
                                    {
                                        foreach (Set s in bestSets)
                                        {
                                            if (isBetterSetThan(neu, s))
                                            {
                                                bestSets.Insert(bestSets.IndexOf(s), new Set(neu));
                                                if (bestSets.Count > anzahlErgebinsse)
                                                    bestSets.RemoveAt(anzahlErgebinsse);
                                                break;
                                            }
                                        }
                                    }
                                    SetLabelText(String.Format("{0} / {1} abgearbeitet", ++count, gesAnzahl));
                                }

                                SetProgressbarValue(count * 100 / gesAnzahl);
                            }
                        }
                    }
                }
            }            

            SetProgressbarValue(100);
            BeginInvoke(EndAutoSetEvent, this, EventArgs.Empty);
        }

        private bool isBetterSetThan(Set a, Set b)
        {
            float sumA = 0, sumB = 0;
            Dictionary<_boniTyp, float> neu = a.getBoniSetSummary();
            Dictionary<_boniTyp, float> old = b.getBoniSetSummary();

            foreach (_boniTyp typ in Enum.GetValues(typeof(_boniTyp)))
            {
                float factor = Boni.getFactorByType(typ);
                sumA += neu[typ] * factor;
                sumB += old[typ] * factor;
            }

                return (sumA > sumB);
        }

        private bool isBetterBoniListThan(Dictionary<_boniTyp, float> neu, Dictionary<_boniTyp, float> old)
        {            
            float sumA = 0, sumB = 0;

            foreach (_boniTyp typ in Enum.GetValues(typeof(_boniTyp)))
            {
                float factor = Boni.getFactorByType(typ);
                sumA += neu[typ] * factor;
                sumB += old[typ] * factor;
            }

            return (sumA > sumB);
        }

        private bool missingKompTolerated(Set s, int maxTolerate)
        {
            return(getMissingKomponents(s) <= maxTolerate);
        }
        #endregion Auto Generate Thread

        private int getMissingKomponents(Set s)
        {
            Dictionary<Komponenten, int> komNeeded = s.getKomponentenSetSummary();

            int ret = 0;

            foreach (Komponenten con in komNeeded.Keys)
            {
                int anzahl;
                if (!komNeeded.TryGetValue(con, out anzahl))
                    anzahl = 0;

                int vorhanden;
                if (!vorhandenKomponenten.TryGetValue(con, out vorhanden))
                    vorhanden = 0;

                ret += (Math.Max(0, anzahl - vorhanden));                
            }

            return ret;
        }        

        private void lw_autosetup_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView l = ((ListView)sender);
            if (l.SelectedIndices.Count > 0)
            {
                autoSetup = bestSets[l.SelectedIndices[0]];
                setSetToComboBox(newSetCbx, autoSetup);
                recalculate(autoSetup);                
            }
        }

        private void cb_overview_Click(object sender, EventArgs e)
        {
            refreshItemUebersicht((KommanderItems)((ComboBox)sender).SelectedItem);
        }

        private void updateSet(object sender, EventArgs e)
        {
            Set akt = (Set)((Button)sender).Tag;
            List<ComboBox> cbx = ( akt == altesSet ? oldSetCbx : newSetCbx);
            setComboBoxToSet(cbx, akt);

            recalculate(neuesSet);            
        }

        private void clearSet(object sender, EventArgs e)
        {
            Set aktSet = (Set)((Button)sender).Tag;
            aktSet.navigation = naviItems[0];
            aktSet.ruestung = ruestungItems[0];
            aktSet.optimierer = optimiererItems[0];
            aktSet.waffe = waffenItems[0];
            aktSet.geraet1 = geraeteItems1[0];
            aktSet.geraet2 = geraeteItems2[0];

            recalculate(neuesSet);            
        }

        private void cb_man_forsch_CheckStateChanged(object sender, EventArgs e)
        {
            recalculate(neuesSet);            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            Einstellungen settingsForm = new Einstellungen();

            // Show the settings form
            settingsForm.Show();
        }
    }

    #region Komponenten
    /// <summary>
    /// 
    /// </summary>
    class Komponenten
    {           
        public String name { get; set; }
        public Image bild { get; set; }
        public _boniTyp neededAb40;
        public _boniTyp neededBis40;

        public Komponenten(String name, Image bild, _boniTyp neededAb40, _boniTyp neededBis40)
        {
            this.name = name;
            this.bild = bild;
            this.neededAb40 = neededAb40;
            this.neededBis40 = neededBis40;
        }

        public static List<Komponenten> _komponenten = new List<Komponenten>
        {
            new Komponenten ("Diamant", Terminator_Genesys_Item_Planer.Properties.Resources.diamant, _boniTyp.forschung, _boniTyp.forschung),
            new Komponenten ("Aerogel", Terminator_Genesys_Item_Planer.Properties.Resources.aerogel, _boniTyp.bau, _boniTyp.bau),
            new Komponenten ("Kupfer", Terminator_Genesys_Item_Planer.Properties.Resources.kupfer, _boniTyp.marsch, _boniTyp.marsch),
            new Komponenten ("Stahl", Terminator_Genesys_Item_Planer.Properties.Resources.stahl, _boniTyp.kavallerieAng, _boniTyp.kavallerieAng),
            new Komponenten ("Microdraht", Terminator_Genesys_Item_Planer.Properties.Resources.microdraht, _boniTyp.sturmtruppenAng, _boniTyp.sturmtruppenAng),
            new Komponenten ("Nanokomposit", Terminator_Genesys_Item_Planer.Properties.Resources.nanokomposit, _boniTyp.infantrieAng, _boniTyp.infantrieAng),
            new Komponenten ("Wolfram", Terminator_Genesys_Item_Planer.Properties.Resources.wolfram, _boniTyp.belagerungAng, _boniTyp.belagerungAng),
            new Komponenten ("Aramit",  Terminator_Genesys_Item_Planer.Properties.Resources.aramid, _boniTyp.luftwaffeAng, _boniTyp.luftwaffeAng),
            new Komponenten ("Silizium", Terminator_Genesys_Item_Planer.Properties.Resources.silizium, _boniTyp.munitionProd, _boniTyp.munitionProd),
            new Komponenten ("Plastik", Terminator_Genesys_Item_Planer.Properties.Resources.plastik, _boniTyp.iridiumProd, _boniTyp.iridiumProd),
            new Komponenten ("Magnet", Terminator_Genesys_Item_Planer.Properties.Resources.magnet, _boniTyp.gesTruppenGes, _boniTyp.gesTruppenGes),
            new Komponenten ("Kevlar", Terminator_Genesys_Item_Planer.Properties.Resources.kevlar, _boniTyp.gesTruppenAbw, _boniTyp.gesTruppenAbw)
        };

        public static Komponenten getKomponenteByName(String name)
        {
            return _komponenten.Find(item => item.name.Equals(name));
        }

        public static Komponenten getKomponenteByTyp(_boniTyp typ, Boolean ab40)
        {
            if(ab40)
                return _komponenten.Find(item => item.neededAb40.Equals(typ));
            else
                return _komponenten.Find(item => item.neededBis40.Equals(typ));
        }
    }
    #endregion Komponenten

    #region Bonus
    enum _boniTyp
        {
            forschung,
            bau,
            marsch,
            kavallerieAng,
            sturmtruppenAng,
            infantrieAng,
            belagerungAng,
            luftwaffeAng,
            munitionProd,
            iridiumProd,
            gesTruppenGes,
            gesTruppenAbw
        }

    /// <summary>
    /// 
    /// </summary>
    class Boni
    {
        public static Dictionary<_boniTyp, String> boniTyp = new Dictionary<_boniTyp, string>
        {
            { _boniTyp.forschung, "Forschungsgeschwindigkeit" },
            { _boniTyp.bau, "Baugeschwindigkeit" },
            { _boniTyp.marsch, "Marschgeschwindigkeit" },
            { _boniTyp.kavallerieAng, "Kavallerie Ang." },
            { _boniTyp.sturmtruppenAng, "Sturmtruppen Ang." },
            { _boniTyp.infantrieAng, "Infantrie Ang." },
            { _boniTyp.belagerungAng, "Belagerung Ang." },
            { _boniTyp.luftwaffeAng, "Luftwaffen Ang." },
            { _boniTyp.munitionProd, "Munition Produktion" },
            { _boniTyp.iridiumProd, "Iridium Produktion" },
            { _boniTyp.gesTruppenGes, "Ges. Truppen Gesundheit" },
            { _boniTyp.gesTruppenAbw, "Ges. Truppen Abwehr" }
        };

        public static Dictionary<_boniTyp, float> boniFactor = new Dictionary<_boniTyp, float>
        {
            { _boniTyp.forschung, (float)Terminator_Genesys_Item_Planer.Properties.Settings.Default.Auto_Forschung },
            { _boniTyp.bau, (float)Terminator_Genesys_Item_Planer.Properties.Settings.Default.Auto_Bau },
            { _boniTyp.marsch, (float)Terminator_Genesys_Item_Planer.Properties.Settings.Default.Auto_Marsch },
            { _boniTyp.kavallerieAng, (float)Terminator_Genesys_Item_Planer.Properties.Settings.Default.Auto_Kavallerie },
            { _boniTyp.sturmtruppenAng, (float)Terminator_Genesys_Item_Planer.Properties.Settings.Default.Auto_Sturm },
            { _boniTyp.infantrieAng, (float)Terminator_Genesys_Item_Planer.Properties.Settings.Default.Auto_Infantrie },
            { _boniTyp.belagerungAng, (float)Terminator_Genesys_Item_Planer.Properties.Settings.Default.Auto_Belagerung },
            { _boniTyp.luftwaffeAng, (float)Terminator_Genesys_Item_Planer.Properties.Settings.Default.Auto_Luftwaffe },
            { _boniTyp.munitionProd, (float)Terminator_Genesys_Item_Planer.Properties.Settings.Default.Auto_Munition },
            { _boniTyp.iridiumProd, (float)Terminator_Genesys_Item_Planer.Properties.Settings.Default.Auto_Iridium },
            { _boniTyp.gesTruppenGes, (float)Terminator_Genesys_Item_Planer.Properties.Settings.Default.Auto_TruppenGesundheit },
            { _boniTyp.gesTruppenAbw, (float)Terminator_Genesys_Item_Planer.Properties.Settings.Default.Auto_TruppenAbwehr }
        };

        public _boniTyp typ { get; set; }
        public float wert { get; set; }
        public Komponenten ab40 { get; set; }
        public Komponenten bis40 { get; set; }
        //public Image bild { get; set; }
        Boolean istAb40 { get; set; }
        public int anzahlKomponente { get; set; } 

        public Boni(_boniTyp typ, float wert, Boolean istAb40, int anzahl )
        {
            this.typ = typ;
            this.wert = wert;
            this.anzahlKomponente = anzahl;
            this.istAb40 = istAb40;
            this.ab40 = Komponenten.getKomponenteByTyp(typ, true);
            this.bis40 = Komponenten.getKomponenteByTyp(typ, false);
        }

        public static String getNameByType(_boniTyp typ)
        {
            return boniTyp[typ];
        }
        
        public static float getFactorByType(_boniTyp typ)
        {
            return boniFactor[typ];
        }

        public static void refreshFactorList()
        {
            boniFactor[_boniTyp.forschung] = Properties.Settings.Default.Auto_Forschung;            
            boniFactor[_boniTyp.bau] = Properties.Settings.Default.Auto_Bau;
            boniFactor[_boniTyp.marsch] = Properties.Settings.Default.Auto_Marsch;
            boniFactor[_boniTyp.kavallerieAng] = Properties.Settings.Default.Auto_Kavallerie;
            boniFactor[_boniTyp.sturmtruppenAng] = Properties.Settings.Default.Auto_Sturm;
            boniFactor[_boniTyp.infantrieAng] = Properties.Settings.Default.Auto_Infantrie;
            boniFactor[_boniTyp.belagerungAng] = Properties.Settings.Default.Auto_Belagerung;
            boniFactor[_boniTyp.luftwaffeAng] = Properties.Settings.Default.Auto_Luftwaffe;
            boniFactor[_boniTyp.munitionProd] = Properties.Settings.Default.Auto_Munition;
            boniFactor[_boniTyp.iridiumProd] = Properties.Settings.Default.Auto_Iridium;
            boniFactor[_boniTyp.gesTruppenGes] = Properties.Settings.Default.Auto_TruppenGesundheit;
            boniFactor[_boniTyp.gesTruppenAbw] = Properties.Settings.Default.Auto_TruppenAbwehr;
        }

        public List<Komponenten> getKomponenten()
        {
            List<Komponenten> komps = new List<Komponenten>();

            for (int i = 0; i < anzahlKomponente; i++)
                komps.Add(istAb40 ? ab40 : bis40);

            return komps;
        }
    }
    #endregion Bonus

    #region Items
    enum _itemSlot
    {
        navigation,
        ruestung,
        waffe,
        optimierer,
        geraet1,
        geraet2        
    }

    /// <summary>
    /// 
    /// </summary>
    class KommanderItems
    {
        String name;
        int lvl;
        int iridium;
        public _itemSlot typ { get; set; }
        List<Boni> boniListe = new List<Boni>();
        //Image bild;

        public KommanderItems(String name, _itemSlot typ, int lvl, int iridium, List<Boni> neoList)
        {
            this.name = name;
            this.typ = typ;
            this.lvl = lvl;
            this.iridium = iridium;
            boniListe.AddRange(neoList);
        }

        public List<Boni> getBoniListe()
        {
            return boniListe;
        }

        public List<Komponenten> getKomponentenListe()
        {
            List<Komponenten> compList = new List<Komponenten>();

            foreach(Boni bon in boniListe)
            {
                compList.AddRange(bon.getKomponenten());
                               
            }

            return compList;
        }

        public override string ToString()
        {
            return name;
        }
    }
    #endregion Items

    #region Set
    class Set
    {
        public KommanderItems navigation { get; set; }
        public KommanderItems ruestung { get; set; }
        public KommanderItems waffe { get; set; }
        public KommanderItems optimierer { get; set; }
        public KommanderItems geraet1 { get; set; }
        public KommanderItems geraet2 { get; set; }
        public Image bild { get; set; }

        List<KommanderItems> fullSet;

        public Set(Set s)
        {
            this.navigation = s.navigation;
            this.ruestung = s.ruestung;
            this.waffe = s.waffe;
            this.optimierer = s.optimierer;
            this.geraet1 = s.geraet1;
            this.geraet2 = s.geraet2;
            this.bild = s.bild;

        fullSet = new List<KommanderItems>(s.fullSet);
    }

        public Set(List<KommanderItems> fullSet, Image bild)
        {
            this.fullSet = new List<KommanderItems> { navigation, ruestung, waffe, optimierer, geraet1, geraet2 };
            fullSetToItems(fullSet);
            this.bild = bild;
        }

        private void fullSetToItems(List<KommanderItems> list)
        {
            foreach(KommanderItems itm in list)
            {
                switch(itm.typ)
                {
                    case _itemSlot.navigation:
                        navigation = itm;
                        break;
                    case _itemSlot.ruestung:
                        ruestung = itm;
                        break;
                    case _itemSlot.optimierer:
                        optimierer = itm;
                        break;
                    case _itemSlot.waffe:
                        waffe = itm;
                        break;
                    case _itemSlot.geraet1:
                        geraet1 = itm;
                        break;
                    case _itemSlot.geraet2:
                        geraet2 = itm;
                        break;
                }
            }
        }

        public void switchItem(_itemSlot typ, KommanderItems item)
        {
            this.fullSet = new List<KommanderItems> { navigation, ruestung, waffe, optimierer, geraet1, geraet2 };

            foreach (KommanderItems komItem in fullSet)
            {                
                if(komItem.typ == typ)
                {
                    fullSet[fullSet.IndexOf(komItem)] = item;
                    break;
                }
            }                
        }

        public Dictionary<_boniTyp, float> getBoniSetSummary()
        {
            this.fullSet = new List<KommanderItems> { navigation, ruestung, waffe, optimierer, geraet1, geraet2 };
            List<Boni> boniListe = new List<Boni>();

            foreach(KommanderItems item in fullSet)
            {
                boniListe.AddRange(item.getBoniListe());
            }

            return generateSummaryFromBoniList(boniListe);
        }

        public static Dictionary<_boniTyp, float> generateSummaryFromBoniList(List<Boni> liste)
        {
            Dictionary<_boniTyp, float> tst = new Dictionary<_boniTyp, float>();

            foreach (_boniTyp typ in Enum.GetValues(typeof(_boniTyp)))
            {
                tst.Add(typ, 0);
            }

            foreach (Boni bon in liste)
            {
                tst[bon.typ] += bon.wert;
            }

            return tst;
        }
        public Dictionary<Komponenten, int> getKomponentenSetSummary()
        {
            this.fullSet = new List<KommanderItems> { navigation, ruestung, waffe, optimierer, geraet1, geraet2 };
            List<Komponenten> kompListe = new List<Komponenten>();

            foreach (KommanderItems item in fullSet)
            {
                kompListe.AddRange(item.getKomponentenListe());
            }

            Dictionary<Komponenten, int> tst = new Dictionary<Komponenten, int>();

            foreach (Komponenten typ in Komponenten._komponenten)
            {
                tst.Add(typ, 0);
            }

            foreach (Komponenten con in kompListe)
            {
                tst[con]++;
            }

            return tst;
        }

        public List<KommanderItems> getSetItems()
        {
            return new List<KommanderItems> { navigation, ruestung, waffe, optimierer, geraet1, geraet2 };
        }
    }
    #endregion Set
}