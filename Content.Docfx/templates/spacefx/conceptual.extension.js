const COMPONENT_BASE_CLASS_UID = "Robust.Shared.GameObjects.Component";


/**
 * This method will be called at the start of exports.transform in conceptual.html.primary.js
 * Model mutations only allowed here, otherwise it's a mess to debug.
 */
exports.preTransform = function (model) {
    if (isComponent(model)) {
        model._dataType = "component";
    }
    return model;
}

/**
 * This method will be called at the end of exports.transform in conceptual.html.primary.js
 */
exports.postTransform = function (model) {
    return model;
}


/**
 * @param model
 * @return True if model is a component
 */
function isComponent(model) {
    const isClass = model.type && model.type === "class";

    if (!isClass || !model.inheritance) {
        return false;
    }

    const inheritsComponentClass = model.inheritance.find(c => c.uid && c.uid === COMPONENT_BASE_CLASS_UID);

    return inheritsComponentClass
}
