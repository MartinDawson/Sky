import { makeRouteConfig, Route } from "found";
import React from "react";

import { routeConfig as customerRouteConfig } from "../../customer/customerContainer";
import { routeConfig as primaryLayoutRouteConfig } from "../../layouts/primaryLayout/primaryLayoutContainer";
import { routeConfig as rewardsRouteConfig } from "../../reward/rewardsContainer";

export default makeRouteConfig(
  <Route path="/" {...primaryLayoutRouteConfig}>
    <Route {...customerRouteConfig} />
    <Route path="rewards" {...rewardsRouteConfig} />
  </Route>,
);
