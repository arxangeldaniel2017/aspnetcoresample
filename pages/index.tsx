import type { NextPage } from "next";
import "bootstrap/dist/css/bootstrap.min.css";
import { ProgressBar } from "react-bootstrap";
import styles from "./index.module.css";

const LandingPage: NextPage = () => {
  return (
    <div className={styles.landingPageDiv}>
      <div className={styles.dressesDiv}>Dresses</div>
      <div className={styles.tagsDiv}>
        <div className={styles.frameDiv}>
          <div className={styles.sheinDiv}>
            <div className={styles.rectangleDiv} />
            <div className={styles.sheinDiv1}>Shein</div>
          </div>
          <div className={styles.sheinDiv}>
            <div className={styles.rectangleDiv} />
            <div className={styles.sheinDiv1}>Black</div>
          </div>
          <button className={styles.miniButton}>
            <button className={styles.rectangleButton} />
            <div className={styles.miniDiv}>Mini</div>
          </button>
          <div className={styles.lightDiv}>
            <div className={styles.frameDiv1}>
              <div className={styles.lightGoldDiv}>Light gold</div>
            </div>
          </div>
          <div className={styles.pltDiv}>
            <div className={styles.frameDiv1}>
              <div className={styles.lightGoldDiv}>PrettyLittleThing</div>
            </div>
          </div>
          <div className={styles.beigeDiv}>
            <div className={styles.frameDiv1}>
              <div className={styles.lightGoldDiv}>Beige</div>
            </div>
          </div>
          <div className={styles.pinkDiv}>
            <div className={styles.frameDiv1}>
              <div className={styles.lightGoldDiv}>Light Pink</div>
            </div>
          </div>
          <div className={styles.redDiv}>
            <div className={styles.frameDiv1}>
              <div className={styles.lightGoldDiv}>Red</div>
            </div>
          </div>
          <div className={styles.darkDiv}>
            <button className={styles.frameButton}>
              <div className={styles.darkDiv1}>Dark</div>
            </button>
          </div>
        </div>
        <div className={styles.rectangleDiv2} />
        <img className={styles.vectorIcon} alt="" src="../vector-7.svg" />
      </div>
      <div className={styles.productsDiv}>172,456 products</div>
      <div className={styles.lengthDiv}>
        <div className={styles.lengthDiv1}>Length</div>
        <img className={styles.vectorIcon1} alt="" src="../vector-9.svg" />
        <img className={styles.vectorIcon2} alt="" src="../vector-10.svg" />
        <div className={styles.mini1Div}>
          <div className={styles.rectangleDiv3} />
          <div className={styles.mini227Div}>
            <span>
              <span>Mini</span>
              <span className={styles.span}>{` `}</span>
            </span>
            <span className={styles.span1}>(22.7)</span>
          </div>
        </div>
        <div className={styles.mini2Div}>
          <input className={styles.rectangleInput} type="checkbox" />
          <div className={styles.mini227Div}>
            <span>
              <span>Mini</span>
              <span className={styles.span}>{` `}</span>
            </span>
            <span className={styles.span1}>(54.9)</span>
          </div>
        </div>
        <div className={styles.maxDiv}>
          <div className={styles.rectangleDiv3} />
          <div className={styles.mini227Div}>
            <span>
              <span>Max</span>
              <span className={styles.span}>{` `}</span>
            </span>
            <span className={styles.span1}>(70.4)</span>
          </div>
        </div>
      </div>
      <div className={styles.sizeDiv}>
        <div className={styles.sizeDiv1}>Size</div>
        <img className={styles.vectorIcon3} alt="" src="../vector-91.svg" />
        <img className={styles.vectorIcon4} alt="" src="../vector-101.svg" />
        <div className={styles.frameDiv6}>
          <div className={styles.xXXSDiv}>XXXS</div>
        </div>
        <div className={styles.frameDiv7}>
          <div className={styles.hDiv}>H</div>
        </div>
        <div className={styles.frameDiv8}>
          <ProgressBar className={styles.xXXLProgressBar} />
        </div>
        <div className={styles.frameDiv9}>
          <div className={styles.xXSDiv}>XXS</div>
        </div>
        <textarea className={styles.frameTextarea} placeholder="L" />
        <div className={styles.frameDiv10}>
          <div className={styles.xXXXLDiv}>XXXXL</div>
        </div>
        <button className={styles.frameButton1}>
          <div className={styles.xSDiv}>XS</div>
        </button>
        <textarea className={styles.frameTextarea1} placeholder="XL" />
        <div className={styles.frameDiv11}>
          <div className={styles.sDiv}>S</div>
        </div>
        <button className={styles.frameButton2}>
          <div className={styles.xXLDiv}>XXL</div>
        </button>
      </div>
      <form className={styles.priceForm}>
        <div className={styles.priceDiv}>Price</div>
        <img className={styles.vectorIcon5} alt="" src="../vector-92.svg" />
        <div className={styles.div}>$0</div>
        <div className={styles.div1}>$5,000</div>
        <img className={styles.meterIcon} alt="" src="../meter.svg" />
        <img className={styles.vectorIcon6} alt="" src="../vector-13.svg" />
        <select className={styles.groupSelect} />
        <button className={styles.groupButton}>
          <button className={styles.rectangleButton1} />
          <div className={styles.div2}>$</div>
          <div className={styles.div3}>3,400</div>
        </button>
        <div className={styles.rectangleDiv5} />
        <div className={styles.justShowMeSales}>Just show me sales</div>
      </form>
      <div className={styles.brandsDiv}>
        <img className={styles.searchIcon} alt="" src="../search.svg" />
        <div className={styles.groupDiv}>
          <div className={styles.brand1Div}>Brand (1)</div>
          <img className={styles.vectorIcon7} alt="" src="../vector-93.svg" />
        </div>
        <img className={styles.vectorIcon8} alt="" src="../vector-102.svg" />
        <div className={styles.gucciDiv}>
          <div className={styles.rectangleDiv3} />
          <div className={styles.mini227Div}>Gucci</div>
        </div>
        <div className={styles.mini3Div}>
          <div className={styles.rectangleDiv3} />
          <div className={styles.mini227Div}>
            <span>
              <span>Mini</span>
              <span className={styles.span}>{` `}</span>
            </span>
            <span className={styles.span1}>(22.7)</span>
          </div>
        </div>
        <div className={styles.mini5Div}>
          <div className={styles.rectangleDiv3} />
          <div className={styles.mini227Div}>
            <span>
              <span>Mini</span>
              <span className={styles.span}>{` `}</span>
            </span>
            <span className={styles.span1}>(22.7)</span>
          </div>
        </div>
        <div className={styles.luiDiv}>
          <div className={styles.groupDiv1}>
            <button className={styles.rectangleButton2} />
          </div>
          <div className={styles.mini227Div}>Lui vi ton</div>
        </div>
        <div className={styles.mini4Div}>
          <div className={styles.rectangleDiv3} />
          <div className={styles.mini227Div}>
            <span>
              <span>Mini</span>
              <span className={styles.span}>{` `}</span>
            </span>
            <span className={styles.span1}>(54.9)</span>
          </div>
        </div>
        <div className={styles.mini6Div}>
          <div className={styles.rectangleDiv3} />
          <div className={styles.mini227Div}>
            <span>
              <span>Mini</span>
              <span className={styles.span}>{` `}</span>
            </span>
            <span className={styles.span1}>(54.9)</span>
          </div>
        </div>
        <div className={styles.maxDiv1}>
          <input className={styles.rectangleInput} type="checkbox" />
          <div className={styles.mini227Div}>
            <span>
              <span>Max</span>
              <span className={styles.span}>{` `}</span>
            </span>
            <span className={styles.span1}>(70.4)</span>
          </div>
        </div>
        <div className={styles.maxDiv2}>
          <input className={styles.rectangleInput} type="checkbox" />
          <div className={styles.mini227Div}>
            <span>
              <span>Max</span>
              <span className={styles.span}>{` `}</span>
            </span>
            <span className={styles.span1}>(70.4)</span>
          </div>
        </div>
        <div className={styles.maxDiv3}>
          <input className={styles.rectangleInput} type="checkbox" />
          <div className={styles.mini227Div}>
            <span>
              <span>Max</span>
              <span className={styles.span}>{` `}</span>
            </span>
            <span className={styles.span1}>(70.4)</span>
          </div>
        </div>
      </div>
      <div className={styles.dress1Div}>
        <div className={styles.rectangleDiv11} />
        <img
          className={styles.maskGroupIcon}
          alt=""
          src="../mask-group@2x.png"
        />
        <div className={styles.redCruiDiv}>Red Crui</div>
        <div className={styles.classyAssymetricDress}>
          Classy Assymetric Dress
        </div>
        <div className={styles.div4}>
          <span>$</span>
          <span className={styles.span20}>1300.</span>
          <span>45</span>
        </div>
        <img className={styles.vectorIcon9} alt="" src="../vector.svg" />
      </div>
      <div className={styles.dress4Div}>
        <div className={styles.rectangleDiv11} />
        <img
          className={styles.maskGroupIcon1}
          alt=""
          src="../mask-group1@2x.png"
        />
        <div className={styles.whiteBloomGown}>White Bloom Gown</div>
        <div className={styles.classyDressDiv}>Classy Dress</div>
        <div className={styles.div5}>
          <span>$</span>
          <span className={styles.span20}>900.</span>
          <span>15</span>
        </div>
        <img className={styles.vectorIcon10} alt="" src="../vector1.svg" />
      </div>
      <div className={styles.dress2Div}>
        <div className={styles.rectangleDiv11} />
        <img
          className={styles.maskGroupIcon2}
          alt=""
          src="../mask-group2@2x.png"
        />
        <div className={styles.simpleOveralDiv}>Simple Overal</div>
        <div className={styles.assymetricDressDiv}>Assymetric Dress</div>
        <div className={styles.div6}>
          <span>$</span>
          <span className={styles.span20}>500.</span>
          <span>53</span>
        </div>
        <img className={styles.vectorIcon11} alt="" src="../vector2.svg" />
      </div>
      <div className={styles.dress7Div}>
        <div className={styles.rectangleDiv11} />
        <img
          className={styles.maskGroupIcon3}
          alt=""
          src="../mask-group3@2x.png"
        />
        <div className={styles.whiteBloomGown}>{`B&W Pattern Gown`}</div>
        <div className={styles.classyDressDiv}>Simple Dress</div>
        <div className={styles.div6}>
          <span>$</span>
          <span className={styles.span20}>600.</span>
          <span>45</span>
        </div>
        <img className={styles.vectorIcon12} alt="" src="../vector3.svg" />
      </div>
      <div className={styles.dress10Div}>
        <div className={styles.rectangleDiv11} />
        <img
          className={styles.maskGroupIcon4}
          alt=""
          src="../mask-group4@2x.png"
        />
        <div className={styles.whiteCDiv}>White C</div>
        <div className={styles.classyAssymetricDress}>
          Classy Assymetric Dress
        </div>
        <div className={styles.div6}>
          <span>$</span>
          <span className={styles.span20}>200.</span>
          <span>05</span>
        </div>
        <img className={styles.vectorIcon13} alt="" src="../vector4.svg" />
      </div>
      <div className={styles.dress5Div}>
        <div className={styles.rectangleDiv11} />
        <img
          className={styles.maskGroupIcon5}
          alt=""
          src="../mask-group5@2x.png"
        />
        <div className={styles.greyMontanaDiv}>Grey Montana</div>
        <div className={styles.easyFlyDressDiv}>Easy FlyDress</div>
        <div className={styles.div9}>
          <span>$</span>
          <span className={styles.span20}>300.</span>
          <span>45</span>
        </div>
        <img className={styles.vectorIcon14} alt="" src="../vector5.svg" />
      </div>
      <div className={styles.dress3Div}>
        <div className={styles.rectangleDiv11} />
        <img
          className={styles.maskGroupIcon6}
          alt=""
          src="../mask-group6@2x.png"
        />
        <div className={styles.goldCrestDiv}>Gold Crest</div>
        <div className={styles.classyAssymetricDress2}>
          Classy Assymetric Dress
        </div>
        <div className={styles.div10}>
          <span>$</span>
          <span className={styles.span20}>1400.</span>
          <span>56</span>
        </div>
        <img className={styles.vectorIcon15} alt="" src="../vector6.svg" />
      </div>
      <div className={styles.dress8Div}>
        <div className={styles.rectangleDiv11} />
        <img
          className={styles.maskGroupIcon7}
          alt=""
          src="../mask-group7@2x.png"
        />
        <div className={styles.gentleJpDiv}>Gentle jp</div>
        <div className={styles.homeRelaxingDress}>Home Relaxing Dress</div>
        <div className={styles.div11}>
          <span>$</span>
          <span className={styles.span20}>300.</span>
          <span>45</span>
        </div>
        <img className={styles.vectorIcon16} alt="" src="../vector7.svg" />
      </div>
      <div className={styles.dress11Div}>
        <div className={styles.rectangleDiv11} />
        <img
          className={styles.maskGroupIcon8}
          alt=""
          src="../mask-group8@2x.png"
        />
        <div className={styles.emilyTamperGown}>Emily Tamper Gown</div>
        <div className={styles.classyAssymetricDress2}>
          Classy Assymetric Dress
        </div>
        <div className={styles.div12}>
          <span>$</span>
          <span className={styles.span20}>1700.</span>
          <span>99</span>
        </div>
        <img className={styles.vectorIcon17} alt="" src="../vector8.svg" />
      </div>
      <div className={styles.dress6Div}>
        <div className={styles.rectangleDiv11} />
        <img
          className={styles.maskGroupIcon9}
          alt=""
          src="../mask-group9@2x.png"
        />
        <div className={styles.hotGirlSummer}>Hot girl summer</div>
        <div className={styles.miamiDressDiv}>Miami Dress</div>
        <div className={styles.div13}>
          <span>$</span>
          <span className={styles.span20}>340.</span>
          <span>45</span>
        </div>
        <img className={styles.vectorIcon18} alt="" src="../vector9.svg" />
      </div>
      <div className={styles.dress9Div}>
        <div className={styles.rectangleDiv11} />
        <img
          className={styles.maskGroupIcon10}
          alt=""
          src="../mask-group10@2x.png"
        />
        <div className={styles.fasseyCDiv}>Fassey C</div>
        <div className={styles.classyDressDiv1}>Classy Dress</div>
        <div className={styles.div14}>
          <span>$</span>
          <span className={styles.span20}>700.</span>
          <span>00</span>
        </div>
        <img className={styles.vectorIcon19} alt="" src="../vector10.svg" />
      </div>
      <div className={styles.dress12Div}>
        <div className={styles.rectangleDiv11} />
        <img
          className={styles.maskGroupIcon11}
          alt=""
          src="../mask-group11@2x.png"
        />
        <div className={styles.lasVegasFancy}>Las Vegas Fancy</div>
        <div className={styles.lasVegasChillDress}>Las Vegas Chill Dress</div>
        <div className={styles.div15}>
          <span>$</span>
          <span className={styles.span20}>1350.</span>
          <span>55</span>
        </div>
        <img className={styles.vectorIcon20} alt="" src="../vector11.svg" />
      </div>
    </div>
  );
};

export default LandingPage;
