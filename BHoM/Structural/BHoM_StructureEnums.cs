﻿
namespace BHoM.Structural
{
    /// <summary>Usage of the bar for downstream implementations</summary>
    public enum BarStructuralUsage
    {
        /// <summary>Beam</summary>
        Beam = 0,
        /// <summary>Column</summary>
        Column,
        /// <summary>Brace</summary>
        Brace,
        /// <summary>Cable</summary>
        Cable
    }

    /// <summary>Manufacture type for steel</summary>
    public enum ManufactureType
    {
        /// <summary>Rolled steel section</summary>
        Rolled = 0,
        /// <summary>Welded steel I-section</summary>
        WeldedIBeam,
        /// <summary>Cold formed hollow section</summary>
        ColdFormed,
        /// <summary>Hot finished hollow section</summary>
        HotFinished,
        /// <summary>Welded steel box section</summary>
        WeldedBox,
        /// <summary>Not known</summary>
        unknown,
    }

    /// <summary>Steel strut buckling curves</summary>
    public enum BucklingCurve
    {
        /// <summary>a0</summary>
        a0 = 0,
        /// <summary>a</summary>
        a,
        /// <summary>b</summary>
        b,
        /// <summary>c</summary>
        c,
        /// <summary>d</summary>
        d,
        /// <summary>Not Known</summary>
        unknown,
    }

    /// <summary>Shear type</summary>
    public enum ShearType
    {
        /// <summary>a</summary>
        a = 0,
        /// <summary>b</summary>
        b,
        /// <summary>c1</summary>
        c1,
        /// <summary>c2</summary>
        c2,
        /// <summary>d</summary>
        d,
        /// <summary>e</summary>
        e,
        /// <summary>f1</summary>
        f1,
        /// <summary>f2</summary>
        f2,
        /// <summary>g</summary>
        g,
    }

    /// <summary>Section classification</summary>
    public enum SectionClass
    {
        /// <summary>c1</summary>
        c1 = 0,
        /// <summary>c2</summary>
        c2,
        /// <summary>c3</summary>
        c3,
        /// <summary>c4</summary>
        c4,
        /// <summary>Not known</summary>
        unknown,
    }

    /// <summary>Axis direction for any application (loads, results, geometry
    /// all cartesian coordinate systems follow the right hand rule</summary>
    public enum AxisDirection
    {
        /// <summary>X direction</summary>
        X = 0,
        /// <summary>Y direction</summary>
        Y = 1,
        /// <summary>Z direction</summary>
        Z = 2,
        /// <summary>Clockwise rotation about X-Axis looking in positive X direction</summary>
        XX = 3,
        /// <summary>Clockwise rotation about Y-Axis looking in positive Y direction</summary>
        YY = 4,
        /// <summary>Clockwise rotation about Z-Axis looking in positive Z direction</summary>
        ZZ = 5
    }

    /// <summary>
    /// Enumerator of types of degrees of freedom
    /// </summary>
    public enum DOFType
    {
        /// <summary>Free - all DOF's released</summary>
        Free = 0,
        /// <summary>Fixed - all DOF's blocked</summary>
        Fixed = 1,
        /// <summary>Zero stiffness in the positive direction</summary>
        FixedNegative = 2,
        /// <summary>Zero stiffness in the negative direction</summary>
        FixedPositive = 3,
        /// <summary>Linear spring constant</summary>
        Spring = 4,
        /// <summary>Non-linear, zero stiffnss in positive direction</summary>
        SpringNegative =5,
        /// <summary>Non-linear, zero stiffness in negative direction</summary>
        SpringPositive = 6,
        /// <summary>Spring stiffness between 0-1 relates to the element to which the DOF applies (e.g. bar end stiffness)</summary>
        SpringRelative = 7,
        /// <summary>As spring negative, but relative stiffness</summary>
        SpringRelativeNegative = 8,
        /// <summary>As spring positive but relative stiffness</summary>
        SpringRelativePositive = 9,
        /// <summary>Non-linear spring model</summary>
        NonLinear = 10,
        /// <summary>Friction model (relative to the load applied)</summary>
        Friction = 11,
        /// <summary>Damped velocities/accelerations</summary>
        Damped = 12,
        /// <summary>Gap model</summary>
        Gap = 13
    }

    /// <summary>Constraint type</summary>
    public enum ConstraintType
    {
        /// <summary>Restraint (e.g. node resraint)</summary>
        Restraint = 0,
        /// <summary>Release (e.g. bar end releases)</summary>
        Release,
        /// <summary>Rigid (e.g. rigid links)</summary>
        Rigid,
        /// <summary>Compatibility (e.g. compatible nodes)</summary>
        Compatibility
    }
}